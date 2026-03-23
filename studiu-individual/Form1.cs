using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace studiu_individual
{
    public partial class Form1 : Form
    {

        private string connectionString = "Data Source=(localdb)\\MSSQLLocalDB;Integrated Security=True;TrustServerCertificate=True;Database=event_db";

        public Form1()
        {
            InitializeComponent();
            load_eventDataGridView();
            load_participantDataGridView();
            load_regDataGridView();
        }

        // ===========================================================
        //
        // Gestionare evenimente
        //
        // ===========================================================

        private void load_eventDataGridView()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = "SELECT * FROM evenimente";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        DataTable dt = new DataTable();
                        dt.Load(reader);
                        eventDataGridView.DataSource = dt;
                    }
                }
            }

            eventDataGridView.Columns["id_eveniment"].Visible = false;

            load_eventComboBox();
            load_reportEventComboBox();
        }

        private void eventDataGridView_SelectionChanged(object sender, EventArgs e)
        {
            if (eventDataGridView.CurrentRow != null)
            {
                denumireTextBox.Text = eventDataGridView.CurrentRow.Cells["denumire"].Value.ToString();
                dateTimePicker_evenimente.Value = (DateTime)eventDataGridView.CurrentRow.Cells["data_"].Value;
                locatieTextBox.Text = eventDataGridView.CurrentRow.Cells["locatie"].Value.ToString();
                locuriTextBox.Text = eventDataGridView.CurrentRow.Cells["locuri_disponibile"].Value.ToString();
                tipEvenimentTextBox.Text = eventDataGridView.CurrentRow.Cells["tip_eveniment"].Value.ToString();
            }
        }

        private void addEvent_Click(object sender, EventArgs e)
        {
            string denumire = denumireTextBox.Text;
            string locatie = locatieTextBox.Text;
            string locuri = locuriTextBox.Text;
            string tipEveniment = tipEvenimentTextBox.Text;

            if (string.IsNullOrEmpty(denumire) || string.IsNullOrEmpty(denumire) ||
                string.IsNullOrEmpty(denumire) || string.IsNullOrEmpty(denumire))
            {
                MessageBox.Show("Completati toate spatiile !");
                return;
            }

            if (dateTimePicker_evenimente.Value == null)
            {
                MessageBox.Show("Selectati o data !");
                return;
            }

            DateTime date = dateTimePicker_evenimente.Value.Date;

            if (!int.TryParse(locuri, out int locuriInt))
            {
                MessageBox.Show("Numarul de locuri nu este valid !");
                return;
            }

            if (locuriInt < 1)
            {
                MessageBox.Show("Numarul de locuri nu poate fi negativ sau nul !");
                return;
            }

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    SqlCommand cmd = new SqlCommand("addEvent", conn);
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@denumireParam", denumire);
                    cmd.Parameters.AddWithValue("@dataParam", date);
                    cmd.Parameters.AddWithValue("@locatieParam", locatie);
                    cmd.Parameters.AddWithValue("@tip_eveniment", tipEveniment);
                    cmd.Parameters.AddWithValue("@nrLocuri", locuriInt);

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Inserare cu succes !");
                    load_eventDataGridView();
                    return;
                }
            }
            catch (Exception err)
            {
                MessageBox.Show("S-a produs o eroare: " + err.Message);
                return;
            }
        }

        private void updateEvent_Click(object sender, EventArgs e)
        {
            if (eventDataGridView.CurrentRow == null)
            {
                MessageBox.Show("Selectati un rand !");
                return;
            }

            int idEveniment = int.Parse(eventDataGridView.CurrentRow.Cells["id_eveniment"].Value.ToString());
            string denumire = denumireTextBox.Text;
            string locatie = locatieTextBox.Text;
            string locuri = locuriTextBox.Text;
            string tipEveniment = tipEvenimentTextBox.Text;


            if (string.IsNullOrEmpty(denumire) || string.IsNullOrEmpty(denumire) ||
                string.IsNullOrEmpty(denumire) || string.IsNullOrEmpty(denumire))
            {
                MessageBox.Show("Completati toate spatiile !");
                return;
            }

            if (dateTimePicker_evenimente.Value == null)
            {
                MessageBox.Show("Selectati o data !");
                return;
            }

            DateTime date = dateTimePicker_evenimente.Value.Date;

            if (!int.TryParse(locuri, out int locuriInt))
            {
                MessageBox.Show("Numarul de locuri nu este valid !");
                return;
            }

            if (locuriInt < 1)
            {
                MessageBox.Show("Numarul de locuri nu poate fi negativ sau nul !");
                return;
            }


            string query = 
                "UPDATE evenimente" +
                " SET" +
                " denumire = @denumire," +
                " data_ = @data," +
                " locatie = @locatie," +
                " locuri_disponibile = @locuri," +
                " tip_eveniment = @tip" +
                " WHERE id_eveniment = @id;";


            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@denumire", denumire);
                        cmd.Parameters.AddWithValue("@data", date);
                        cmd.Parameters.AddWithValue("@locatie", locatie);
                        cmd.Parameters.AddWithValue("@locuri", locuriInt);
                        cmd.Parameters.AddWithValue("@tip", tipEveniment);
                        cmd.Parameters.AddWithValue("@id", idEveniment);

                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Actualizare cu succes !");
                        load_eventDataGridView();
                        return;
                    }
                }
            }
            catch (Exception err)
            {
                MessageBox.Show("S-a produs o eroare: " + err.Message);
                return;
            }
        }

        private void deleteEvent_Click(object sender, EventArgs e)
        {
            if (eventDataGridView.CurrentRow == null)
            {
                MessageBox.Show("Selectati un rand !");
                return;
            }

            int idEveniment = int.Parse(eventDataGridView.CurrentRow.Cells["id_eveniment"].Value.ToString());


            DialogResult result = MessageBox.Show(
                "Vrei sa continui operatiunea de stergere !",
                "Confirmare",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );


            if (result == DialogResult.Yes)
            {
                try
                {
                    using (SqlConnection conn = new SqlConnection(connectionString))
                    {
                        conn.Open();
                        string query = "DELETE FROM evenimente WHERE id_eveniment = @id";
                        SqlCommand cmd = new SqlCommand(query, conn);
                        cmd.Parameters.AddWithValue("@id", idEveniment);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Stergere efecuata cu succes !");
                        load_eventDataGridView();
                        return;
                    }
                }
                catch (Exception err)
                {
                    MessageBox.Show("S-a produs o eroare: " + err.Message);
                    return;
                }

            }

        }

        private void searchEvent_Click(object sender, EventArgs e)
        {
            string searchQuery = searchEventTextBox.Text;

            if (string.IsNullOrEmpty(searchQuery))
            {
                load_eventDataGridView();
            }
            else
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string query = "SELECT * FROM evenimente WHERE LOWER(locatie) = LOWER(N'" + searchQuery + "') OR LOWER(tip_eveniment) = LOWER(N'" + searchQuery + "');";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {

                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            DataTable dt = new DataTable();
                            dt.Load(reader);
                            eventDataGridView.DataSource = dt;
                        }
                    }
                }
                eventDataGridView.Columns["id_eveniment"].Visible = false;
            }
        }


        // ===========================================================
        //
        // Gestionare participanti
        //
        // ===========================================================

        private void load_participantDataGridView()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = "SELECT * FROM participanti";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        DataTable dt = new DataTable();
                        dt.Load(reader);
                        participantDataGridView.DataSource = dt;
                    }
                }
            }

            participantDataGridView.Columns["id_participant"].Visible = false;

            load_participantComboBox();
        }

        private void participantDataGridView_SelectionChanged(object sender, EventArgs e)
        {
            if (participantDataGridView.CurrentRow != null)
            {
                numeTextBox.Text = participantDataGridView.CurrentRow.Cells["nume"].Value.ToString();
                prenumeTextBox.Text = participantDataGridView.CurrentRow.Cells["prenume"].Value.ToString();
                emailTextBox.Text = participantDataGridView.CurrentRow.Cells["email"].Value.ToString();
            }
        }

        private void addParticipant_Click(object sender, EventArgs e)
        {
            string nume = numeTextBox.Text;
            string prenume = prenumeTextBox.Text;
            string email = emailTextBox.Text;

            if (string.IsNullOrEmpty(nume) || string.IsNullOrEmpty(prenume) || string.IsNullOrEmpty(email))
            {
                MessageBox.Show("Completati toate spatiile !");
                return;
            }

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    SqlCommand cmd = new SqlCommand("addParticipant", conn);
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@numeParam", nume);
                    cmd.Parameters.AddWithValue("@prenumeParam", prenume);
                    cmd.Parameters.AddWithValue("@emailParam", email);

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Inserare cu succes !");
                    load_participantDataGridView();
                    return;
                }
            }
            catch (Exception err)
            {
                MessageBox.Show("S-a produs o eroare: " + err.Message);
                return;
            }
        }

        private void updateParticipant_Click(object sender, EventArgs e)
        {
            if (participantDataGridView.CurrentRow == null)
            {
                MessageBox.Show("Selectati un rand !");
                return;
            }

            int idParticipant = int.Parse(participantDataGridView.CurrentRow.Cells["id_participant"].Value.ToString());
            string nume = numeTextBox.Text;
            string prenume = prenumeTextBox.Text;
            string email = emailTextBox.Text;

            if (string.IsNullOrEmpty(nume) || string.IsNullOrEmpty(prenume) || string.IsNullOrEmpty(email))
            {
                MessageBox.Show("Completati toate spatiile !");
                return;
            }

            string query = "UPDATE participanti SET nume = @nume, prenume = @prenume, email = @email WHERE id_participant = @id";

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@nume", nume);
                        cmd.Parameters.AddWithValue("@prenume", prenume);
                        cmd.Parameters.AddWithValue("@email", email);
                        cmd.Parameters.AddWithValue("@id", idParticipant);

                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Actualizare cu succes !");
                        load_participantDataGridView();
                        return;
                    }
                }
            }
            catch (Exception err)
            {
                MessageBox.Show("S-a produs o eroare: " + err.Message);
                return;
            }
        }

        private void deleteParticipant_Click(object sender, EventArgs e)
        {
            if (participantDataGridView.CurrentRow == null)
            {
                MessageBox.Show("Selectati un rand !");
                return;
            }

            int idParticipant = int.Parse(participantDataGridView.CurrentRow.Cells["id_participant"].Value.ToString());

            DialogResult result = MessageBox.Show(
                "Vrei sa continui operatiunea de stergere !",
                "Confirmare",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (result == DialogResult.Yes)
            {
                try
                {
                    using (SqlConnection conn = new SqlConnection(connectionString))
                    {
                        conn.Open();
                        string query = "DELETE FROM participanti WHERE id_participant = @id";
                        SqlCommand cmd = new SqlCommand(query, conn);
                        cmd.Parameters.AddWithValue("@id", idParticipant);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Stergere efecuata cu succes !");
                        load_participantDataGridView();
                        return;
                    }
                }
                catch (Exception err)
                {
                    MessageBox.Show("S-a produs o eroare: " + err.Message);
                    return;
                }
            }
        }

        private void searchParticipant_Click(object sender, EventArgs e)
        {
            string searchQuery = searchParticipantTextBox.Text;

            if (string.IsNullOrEmpty(searchQuery))
            {
                load_participantDataGridView();
            }
            else
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string query = "SELECT * FROM participanti WHERE  LOWER(nume) = LOWER(N'" + searchQuery + "') OR LOWER(email) = LOWER(N'" + searchQuery + "')";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {

                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            DataTable dt = new DataTable();
                            dt.Load(reader);
                            participantDataGridView.DataSource = dt;
                        }
                    }
                }

                participantDataGridView.Columns["id_participant"].Visible = false;
            }
        }

        // ===========================================================
        //
        // Gestionare inscrieri
        //
        // ===========================================================

        private void load_regDataGridView()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = "SELECT * FROM selectParticipantsPerEvent";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        DataTable dt = new DataTable();
                        dt.Load(reader);
                        regDataGridView.DataSource = dt;
                    }
                }
            }

            regDataGridView.Columns["id_participant"].Visible = false;
            regDataGridView.Columns["id_eveniment"].Visible = false;
        }

        private void load_eventComboBox()
        {
            string query = "SELECT id_eveniment, denumire, data_, locatie FROM evenimente";
            var evenimente = new List<dynamic> { };

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            evenimente.Add(new { Id = reader.GetInt32(0), Display = reader.GetString(1) + " " + reader.GetString(3) + " " + reader.GetDateTime(2).ToString("dd/MM/yyyy") });
                        }
                    }
                }
            }

            eventComboBox.DataSource = evenimente;
            eventComboBox.DisplayMember = "Display";
            eventComboBox.ValueMember = "Id";
        }

        private void load_participantComboBox()
        {
            string query = "SELECT id_participant, nume, prenume, email FROM participanti";
            var participanti = new List<dynamic> { };

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            participanti.Add(new { Id = reader.GetInt32(0), Display = reader.GetString(1) + " " + reader.GetString(2) + " " + reader.GetString(3) });
                        }
                    }
                }
            }

            participantComboBox.DataSource = participanti;
            participantComboBox.DisplayMember = "Display";
            participantComboBox.ValueMember = "Id";
        }

        private void newRegistration_Click(object sender, EventArgs e)
        {

            if (eventComboBox.SelectedValue == null || participantComboBox.SelectedValue == null)
            {
                MessageBox.Show("Selectati o valoare pentru eveniment si participant !");
                return;
            }

            if (string.IsNullOrEmpty(statusTextBox.Text))
            {
                MessageBox.Show("Indicati un status !");
                return;
            }

            int eventId = int.Parse(eventComboBox.SelectedValue.ToString());
            int participantId = int.Parse(participantComboBox.SelectedValue.ToString());

            string status = statusTextBox.Text;


            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    SqlCommand cmd = new SqlCommand("regParticipant", conn);
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@idParticipant", participantId);
                    cmd.Parameters.AddWithValue("@idEveniment", eventId);
                    cmd.Parameters.AddWithValue("@status", status);

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Inserare cu succes !");
                    load_regDataGridView();
                    return;
                }
            }
            catch (Exception err)
            {
                MessageBox.Show("S-a produs o eroare: " + err.Message);
                return;
            }
        }

        private void showAllRegistration_Click(object sender, EventArgs e)
        {
            load_regDataGridView();
        }

        private void searchRegistrationByEvent_Click(object sender, EventArgs e)
        {
            if (eventComboBox.SelectedValue == null)
            {
                MessageBox.Show("Selectati un eveniment!");
                return;
            }

            int eventId = int.Parse(eventComboBox.SelectedValue.ToString());

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = "SELECT * FROM selectParticipantsPerEvent WHERE id_eveniment = @id";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@id", eventId);
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        DataTable dt = new DataTable();
                        dt.Load(reader);
                        regDataGridView.DataSource = dt;
                    }
                }
            }

            regDataGridView.Columns["id_participant"].Visible = false;
            regDataGridView.Columns["id_eveniment"].Visible = false;
        }

        private void searchRegistrationByStatus_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(statusTextBox.Text))
            {
                MessageBox.Show("Indicati un status !");
                return;
            }

            string status = statusTextBox.Text;

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = "SELECT * FROM selectParticipantsPerEvent WHERE LOWER(status_) = LOWER(@status)";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@status", status);
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        DataTable dt = new DataTable();
                        dt.Load(reader);
                        regDataGridView.DataSource = dt;
                    }
                }
            }

            regDataGridView.Columns["id_participant"].Visible = false;
            regDataGridView.Columns["id_eveniment"].Visible = false;
        }


        // ===========================================================
        //
        // Gestionare rapoarte
        //
        // ===========================================================


        private void Form1_Load(object sender, EventArgs e)
        {
            this.reportViewer1.RefreshReport();
        }

        private void load_reportEventComboBox()
        {
            string query = "SELECT id_eveniment, denumire, data_, locatie FROM evenimente";
            var evenimente = new List<dynamic> { };

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            evenimente.Add(new { Id = reader.GetInt32(0), Display = reader.GetString(1) + " " + reader.GetString(3) + " " + reader.GetDateTime(2).ToString("dd/MM/yyyy") });
                        }
                    }
                }
            }

            reportEventsComboBox.DataSource = evenimente;
            reportEventsComboBox.DisplayMember = "Display";
            reportEventsComboBox.ValueMember = "Id";
        }

        private void reportNrOfParticipantPerEvent_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                string query = "SELECT * FROM nrOfParticipantsByEvents_vw";
                SqlCommand command = new SqlCommand(query, conn);

                SqlDataAdapter da = new SqlDataAdapter(command);
                da.Fill(dt);
            }

            if (dt.Rows.Count == 0)
            {
                MessageBox.Show("Nu s-au găsit înregistrări pentru filtrul dat!");
                return;
            }

            reportViewer1.LocalReport.ReportPath = "Reports\\Report1.rdlc";
            ReportDataSource ds = new ReportDataSource("DataSet1", dt);

            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.DataSources.Add(ds);

            reportViewer1.RefreshReport();
        }

        private void participantsOnSpecificEvent_Click(object sender, EventArgs e)
        {
            if(reportEventsComboBox.SelectedValue == null)
            {
                MessageBox.Show("Selectati un eveniment !");
                return;
            }

            int selectedEvent = (int)reportEventsComboBox.SelectedValue;
            
            DataTable dt = new DataTable();
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                string query = "SELECT * FROM participantOnSpecificEvent_vw WHERE id_eveniment = @idEvent";
                SqlCommand command = new SqlCommand(query, conn);
                command.Parameters.Clear();
                command.Parameters.AddWithValue("@idEvent", selectedEvent);

                SqlDataAdapter da = new SqlDataAdapter(command);
                da.Fill(dt);
            }

            if (dt.Rows.Count == 0)
            {
                MessageBox.Show("Nu s-au găsit înregistrări pentru filtrul dat!");
                return;
            }

            reportViewer1.LocalReport.ReportPath = "Reports\\Report2.rdlc";
            ReportDataSource ds = new ReportDataSource("DataSet2", dt);

            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.DataSources.Add(ds);

            reportViewer1.RefreshReport();
        }
    }
}
