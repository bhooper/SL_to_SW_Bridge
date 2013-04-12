using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SL_to_SW_Bridge
{
    public partial class ItemCreate : Form
    {
        public ItemCreate(string in_item, string in_description)
        {
            InitializeComponent();

            itemtxt.Text = in_item;

            desctxt.Text = in_description;

            this.Text += in_item;

            this.KeyPreview = true;

            this.KeyDown += new KeyEventHandler(ItemCreate_KeyDown);

            weighttxt.KeyPress += new KeyPressEventHandler(weight_KeyPress);

            weighttxt.KeyDown += new KeyEventHandler(weighttxt_KeyDown);

        }

        void weighttxt_KeyDown(object sender, KeyEventArgs e)
        {
            KeydownNumeric(e, weighttxt);
        }

        void weight_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (NonNumber)
                e.Handled = true;
        }

        private bool NonNumber { get; set; }

        public void KeydownNumeric(KeyEventArgs e, TextBox textbox)
        {
            NonNumber = false;

            if (e.KeyCode < Keys.D0 || e.KeyCode > Keys.D9)
            {
                if (e.KeyCode < Keys.NumPad0 || e.KeyCode > Keys.NumPad9)
                {
                    if (e.KeyCode != Keys.Back)
                        NonNumber = true;
                }
            }
            if (Control.ModifierKeys == Keys.Shift)
                NonNumber = true;

            if (e.KeyCode == Keys.OemPeriod || e.KeyCode == Keys.Decimal)
            {
                if (!(textbox.Text.Contains(".")))
                    NonNumber = false;
                else
                    NonNumber = true;
            }
            if (e.KeyCode == Keys.Return || e.KeyCode == Keys.Enter)
                NonNumber = false;

            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
                this.Dispose();
            }
        }

        void ItemCreate_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Alt && e.Control && e.KeyCode == Keys.M)
            {
                //ExistsInM2M();
            }
        }

        private bool ViableToDump()
        {
            bool retval = true;

            if (itemtxt.Text == "")
                retval = false;

            return retval;
        }

        private void ExistsInM2M()
        {
            try
            {

            }
            catch
            {
                MessageBox.Show("Made2Manage is not accessible or another error has occured.\nCheck data integrity and Made2Manage status before trying again.", "Made2Manage Error!", MessageBoxButtons.OK, MessageBoxIcon.Stop);

                throw new NotImplementedException();
            }
        }

        private void ItemCreate_Load(object sender, EventArgs e)
        {
            try
            {
                this.famcodeTableAdapter.Fill(this.dEKKER_AppDataSet.famcode);

                this.prodcodeTableAdapter.Fill(this.dEKKER_AppDataSet.prodcode);

                this.u_mTableAdapter.Fill(this.dEKKER_AppDataSet.u_m);

                costtypecbo.SelectedIndex = 1;

                costmethodcbo.SelectedIndex = 2;

                abccbo.SelectedIndex = 2;

                typecbo.SelectedIndex = 0;

                sourcecbo.SelectedIndex = 1;
            }
            catch { }

        }

        private ItemRecord CollectItem()
        {
            return null;
        }

        private void cancelbtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void continuebtn_Click(object sender, EventArgs e)
        {
            //process new item into syteline

            if (ViableToDump())
            {
                ItemRecord toAdd = new ItemRecord();

                toAdd = CollectItem();

                //System.Data.SqlClient.SqlTransaction transaction = null;

                try
                {
                    //transaction = TableAdapterHelper.BeginTransaction(itemTableAdapter);

                    //itemTableAdapter.InsertNewItem(toAdd.item, toAdd.description, toAdd.qty_allocjob, toAdd.u_m, toAdd.lead_time, toAdd.lot_size, toAdd.qty_used_ytd, toAdd.qty_mfg_ytd, toAdd.abc_code, toAdd.drawing_nbr, toAdd.product_code, toAdd.p_m_t_code, toAdd.cost_method, toAdd.lst_lot_size, toAdd.unit_cost, toAdd.lst_u_cost, toAdd.avg_u_cost, toAdd.job, toAdd.suffix, toAdd.stocked, toAdd.matl_type, toAdd.family_code, toAdd.low_level, toAdd.last_inv, toAdd.days_supply, toAdd.order_min, toAdd.order_mult, toAdd.plan_code, toAdd.mps_flag, toAdd.accept_req, toAdd.change_date, toAdd.revision, toAdd.phantom_flag, toAdd.plan_flag, toAdd.paper_time, toAdd.dock_time, toAdd.asm_setup, toAdd.asm_run, toAdd.asm_matl, toAdd.asm_tool, toAdd.asm_fixture, toAdd.asm_other, toAdd.asm_fixed, toAdd.asm_var, toAdd.asm_outside, toAdd.comp_setup, toAdd.comp_run, toAdd.comp_matl, toAdd.comp_tool, toAdd.comp_fixture, toAdd.comp_other, toAdd.comp_fixed, toAdd.comp_var, toAdd.comp_outside, toAdd.sub_matl, toAdd.shrink_fact, toAdd.alt_item, toAdd.unit_weight, toAdd.weight_units, toAdd.charfld4, toAdd.cur_u_cost, toAdd.feat_type, toAdd.var_lead, toAdd.feat_str, toAdd.next_config, toAdd.feat_templ, toAdd.backflush, toAdd.charfld1, toAdd.charfld2, toAdd.charfld3, toAdd.decifld1, toAdd.decifld2, toAdd.decifld3, toAdd.logifld, toAdd.datefld, toAdd.track_ecn, toAdd.u_ws_price, toAdd.comm_code, toAdd.origin, toAdd.unit_mat_cost, toAdd.unit_duty_cost, toAdd.unit_freight_cost, toAdd.unit_brokerage_cost, toAdd.cur_mat_cost, toAdd.cur_duty_cost, toAdd.cur_freight_cost, toAdd.cur_brokerage_cost, toAdd.tax_code1, toAdd.tax_code2, toAdd.bflush_loc, toAdd.reservable, toAdd.shelf_life, toAdd.lot_prefix, toAdd.serial_prefix, toAdd.serial_length, toAdd.issue_by, toAdd.serial_tracked, toAdd.lot_tracked, toAdd.cost_type, toAdd.matl_cost, toAdd.lbr_cost, toAdd.fovhd_cost, toAdd.vovhd_cost, toAdd.out_cost, toAdd.cur_mat_cost, toAdd.cur_lbr_cost, toAdd.cur_fovhd_cost, toAdd.cur_vovhd_cost, toAdd.cur_out_cost, toAdd.avg_matl_cost, toAdd.avg_lbr_cost, toAdd.avg_fovhd_cost, toAdd.avg_vovhd_cost, toAdd.avg_out_cost, toAdd.prod_type, toAdd.rate_per_day, toAdd.mps_plan_fence, toAdd.pass_req, toAdd.lot_gen_exp, toAdd.supply_site, toAdd.prod_mix, toAdd.stat, toAdd.status_chg_user_code, toAdd.chg_date, toAdd.reason_code, toAdd.supply_whse, 
                    //    toAdd.due_period, toAdd.order_max, toAdd.mrp_part, toAdd.infinite_part, toAdd.NoteExistsFlag, toAdd.RecordDate, toAdd.supply_tolerance_hrs, toAdd.exp_lead_time, toAdd.var_exp_lead, toAdd.buyer, toAdd.order_configurable, toAdd.job_configurable, toAdd.cfg_model, toAdd.co_post_config, toAdd.job_post_config, toAdd.auto_job, toAdd.auto_post, toAdd.setupgroup, toAdd.CreatedBy, toAdd.UpdatedBy, toAdd.CreateDate, toAdd.InWorkflow, toAdd.mfg_supply_switching_active, toAdd.time_fence_rule, toAdd.time_fence_value, toAdd.earliest_planned_po_receipt, toAdd.use_reorder_point, toAdd.reorder_point, toAdd.fixed_order_qty, toAdd.unit_insurance_cost, toAdd.unit_loc_frt_cost, toAdd.cur_insurance_cost, toAdd.cur_loc_frt_cost, toAdd.tax_free_matl, toAdd.tax_free_days, toAdd.safety_stock_percent, toAdd.tariff_classification, toAdd.active_for_data_integration, toAdd.rcvd_over_po_qty_tolerance, toAdd.rcvd_under_po_qty_tolerance, toAdd.include_in_net_change_planning, toAdd.kit, toAdd.print_kit_components, toAdd.safety_stock_rule, toAdd.show_in_drop_down_list, toAdd.controlled_by_external_ics, toAdd.inventory_ucl_tolerance, toAdd.inventory_lcl_tolerance, toAdd.separation_attribute, toAdd.batch_release_attribute1, toAdd.batch_release_attribute2, toAdd.batch_release_attribute3, toAdd.picture, toAdd.active_for_customer_portal, toAdd.featured, toAdd.top_seller, toAdd.overview, toAdd.preassign_lots, toAdd.preassign_serials, toAdd.attr_group, toAdd.dimension_group, toAdd.lot_attr_group, toAdd.track_pieces, toAdd.bom_last_import_date, toAdd.save_current_rev_upon_bom_import);

                    //transaction.Commit();

                    int VendCount = 0;

                    try
                    {
                        //VendCount = Convert.ToInt32(itemvendTableAdapter.CountVendors(itemtxt.Text));
                    }
                    catch { VendCount = 0; }

                    if (sourcecbo.Text == "Purchased" && VendCount == 0)
                    {
                        //add vendor

                        ItemVendorAdd form = new ItemVendorAdd(itemtxt.Text);

                        form.ShowDialog();

                        if (form.DialogResult == DialogResult.Cancel)
                        {
                            this.DialogResult = DialogResult.Cancel;
                        }

                        form.Dispose();
                    }
                }
                catch
                {
                    //transaction.Rollback();

                    this.DialogResult = DialogResult.Cancel;

                    MessageBox.Show("An error occured while trying to inject the item into Syteline.  Operations will now stop.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    this.Close();

                    this.Dispose();

                    return;
                }
                finally
                {
                   //transaction.Connection.Close();

                    //transaction.Dispose();

                    this.Close();
                }
            }
        }
    }
}
