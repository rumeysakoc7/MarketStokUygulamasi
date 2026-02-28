using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarketStokUygulamsı_
{
    public class DatagridViewFormat
    {
        public static void AutoFormatStatusColumns(DataGridView dataGridView, DataGridViewCellFormattingEventArgs e)
        {
            try
            {
                foreach (DataGridViewColumn column in dataGridView.Columns)
                {
                    if (column.Name.Equals("Durum", StringComparison.OrdinalIgnoreCase))
                    {
                        if (e.ColumnIndex == column.Index)
                        {
                            
                            int durum = Convert.ToInt32(dataGridView.Rows[e.RowIndex].Cells[column.Index].Value);

                            if (durum == 0) 
                            {
                                dataGridView.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.LightGray;
                                dataGridView.Rows[e.RowIndex].DefaultCellStyle.ForeColor = Color.DarkGray;
                            }
                            else 
                            {
                                if (dataGridView.Columns.Contains("StokMiktari"))
                                {
                                    int stokMiktari = Convert.ToInt32(dataGridView.Rows[e.RowIndex].Cells["StokMiktari"].Value);

                                    if (stokMiktari < 20) 
                                    {
                                        dataGridView.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.Red;
                                        dataGridView.Rows[e.RowIndex].DefaultCellStyle.ForeColor = Color.White;
                                    }
                                    else 
                                    {
                                        dataGridView.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.White;
                                        dataGridView.Rows[e.RowIndex].DefaultCellStyle.ForeColor = Color.Black;
                                    }
                                }
                            }
                            break;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Renk ayarı sırasında bir hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
