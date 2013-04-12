using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SL_to_SW_Bridge
{
        public class BillItem : IComparable<BillItem>
        {
            public string Parent_item { get; set; }

            public string Item { get; set; }

            public double Length { get; set; }

            public double Qty { get; set; }

            public string Description { get; set; }

            public int CompareTo(BillItem other)
            {
                return Item.CompareTo(other.Item);
            }
        }

        public class ExistingBillItem : IComparable<ExistingBillItem>
        {
            public string Item { get; set; }

            public int sequence { get; set; }

            public double qty { get; set; }

            public string u_m { get; set; }

            public int CompareTo(ExistingBillItem other)
            {
                return Item.CompareTo(other.Item);
            }
        }

        public class OperationItem
        {
            public string WC { get; set; }

            public int Operation { get; set; }

            public double LaborHours { get; set; }

            public double SetupHours { get; set; }
        }

        public class ItemRecord
        {
            public string item { get; set; }

            public string description { get; set; }

            public string revision { get; set; }

            public decimal unit_weight { get; set; }

            public string u_m { get; set; }

            public string drawing_nbr { get; set; }

            public short lead_time { get; set; }

            public string overview { get; set; }

            public byte phantom_flag { get; set; }

            public byte serial_tracked { get; set; }

            public byte track_ecn { get; set; }

            public byte preassign_serials { get; set; }

            public string matl_type { get; set; }

            public string p_m_t_code { get; set; }

            public string abc_code { get; set; }

            public string product_code { get; set; }

            public string cost_method { get; set; }

            public string cost_type { get; set; }

            public string family_code { get; set; }

            public string CreatedBy { get; set; }

            public DateTime CreateDate = DateTime.Now;

            public string UpdatedBy { get; set; }

            public decimal qty_allocjob = 0;

            public decimal lot_size = 1;
            public decimal qty_used_ytd = 0;
            public decimal qty_mfg_ytd = 0;


            public decimal lst_lot_size = 0;
            public decimal unit_cost = 0;
            public decimal lst_u_cost = 0;
            public decimal avg_u_cost = 0;
            public string job = null;
            public short suffix = 0;
            public byte stocked = 1;

            public byte low_level = 0;
            public Nullable<DateTime> last_inv = null;
            public short days_supply = 1;
            public decimal order_min = 0;
            public decimal order_mult = 0;
            public string plan_code = null;
            public byte mps_flag = 0;
            public byte accept_req = 1;
            public Nullable<DateTime> change_date = null;

            public byte plan_flag = 0;
            public short paper_time = 0;
            public short dock_time = 0;
            public decimal asm_setup = 0;
            public decimal asm_run = 0;
            public decimal asm_matl = 0;
            public decimal asm_tool = 0;
            public decimal asm_fixture = 0;
            public decimal asm_other = 0;
            public decimal asm_fixed = 0;
            public decimal asm_var = 0;
            public decimal asm_outside = 0;
            public decimal comp_setup = 0;
            public decimal comp_run = 0;
            public decimal comp_matl = 0;
            public decimal comp_tool = 0;
            public decimal comp_fixture = 0;
            public decimal comp_other = 0;
            public decimal comp_fixed = 0;
            public decimal comp_var = 0;
            public decimal comp_outside = 0;
            public decimal sub_matl = 0;
            public decimal shrink_fact = 0;
            public string alt_item = null;

            public string weight_units = "LBS";
            public string charfld4 = null;
            public decimal cur_u_cost = 0;
            public string feat_type = "I";
            public decimal var_lead = 0;
            public string feat_str = null;
            public short next_config = 1;
            public string feat_templ = null;
            public byte backflush = 1;
            public string charfld1 = null;
            public string charfld2 = null;
            public string charfld3 = null;
            public decimal decifld1 = 0;
            public decimal decifld2 = 0;
            public Nullable<decimal> decifld3 = null;
            public byte logifld = 0;
            public Nullable<DateTime> datefld = null;

            public decimal u_ws_price = 0;
            public string comm_code = null;
            public string origin = null;
            public decimal unit_mat_cost = 0;
            public decimal unit_duty_cost = 0;
            public decimal unit_freight_cost = 0;
            public decimal unit_brokerage_cost = 0;
            public decimal cur_mat_cost = 0;
            public decimal cur_duty_cost = 0;
            public decimal cur_freight_cost = 0;
            public decimal cur_brokerage_cost = 0;
            public string tax_code1 = null;
            public string tax_code2 = null;
            public string bflush_loc = null;
            public byte reservable = 0;
            public Nullable<short> shelf_life = null;
            public string lot_prefix = null;
            public string serial_prefix = null;
            public byte serial_length = 30;
            public string issue_by = "LOT";

            public byte lot_tracked = 0;

            public decimal matl_cost = 0;
            public decimal lbr_cost = 0;
            public decimal fovhd_cost = 0;
            public decimal vovhd_cost = 0;
            public decimal out_cost = 0;
            public decimal cur_matl_cost = 0;
            public decimal cur_lbr_cost = 0;
            public decimal cur_fovhd_cost = 0;
            public decimal cur_vovhd_cost = 0;
            public decimal cur_out_cost = 0;
            public decimal avg_matl_cost = 0;
            public decimal avg_lbr_cost = 0;
            public decimal avg_fovhd_cost = 0;
            public decimal avg_vovhd_cost = 0;
            public decimal avg_out_cost = 0;
            public string prod_type = "J";
            public decimal rate_per_day = 1;
            public Nullable<short> mps_plan_fence = null;
            public byte pass_req = 1;
            public byte lot_gen_exp = 0;
            public string supply_site = null;
            public string prod_mix = null;
            public string stat = "A";
            public string status_chg_user_code = null;
            public Nullable<DateTime> chg_date = null;
            public string reason_code = null;
            public string supply_whse = null;
            public Nullable<short> due_period = null;
            public decimal order_max = 0;
            public byte mrp_part = 0;
            public byte infinite_part = 0;
            public byte NoteExistsFlag = 0;
            public DateTime RecordDate = DateTime.Now;

            public decimal supply_tolerance_hrs = 0;
            public short exp_lead_time = 0;
            public decimal var_exp_lead = 0;
            public string buyer = null;
            public byte order_configurable = 0;
            public byte job_configurable = 0;
            public string cfg_model = null;
            public string co_post_config = null;
            public string job_post_config = null;
            public string auto_job = "N";
            public string auto_post = "N";
            public string setupgroup = null;

            public byte InWorkflow = 0;
            public byte mfg_supply_switching_active = 0;
            public short time_fence_rule = 0;
            public double time_fence_value = 0;
            public Nullable<DateTime> earliest_planned_po_receipt = null;
            public byte use_reorder_point = 0;
            public Nullable<decimal> reorder_point = null;
            public Nullable<decimal> fixed_order_qty = null;
            public decimal unit_insurance_cost = 0;
            public decimal unit_loc_frt_cost = 0;
            public decimal cur_insurance_cost = 0;
            public decimal cur_loc_frt_cost = 0;
            public byte tax_free_matl = 0;
            public Nullable<short> tax_free_days = null;
            public decimal safety_stock_percent = 0;
            public string tariff_classification = null;
            public byte active_for_data_integration = 1;
            public Nullable<decimal> rcvd_over_po_qty_tolerance = null;
            public Nullable<decimal> rcvd_under_po_qty_tolerance = null;
            public byte include_in_net_change_planning = 1;
            public byte kit = 0;
            public byte print_kit_components = 0;
            public short safety_stock_rule = 1;
            public byte show_in_drop_down_list = 1;
            public byte controlled_by_external_ics = 0;
            public Nullable<decimal> inventory_ucl_tolerance = null;
            public Nullable<decimal> inventory_lcl_tolerance = null;
            public string separation_attribute = null;
            public Nullable<double> batch_release_attribute1 = null;
            public Nullable<double> batch_release_attribute2 = null;
            public Nullable<double> batch_release_attribute3 = null;
            public byte[] picture = null;
            public byte active_for_customer_portal = 0;
            public byte featured = 0;
            public byte top_seller = 0;

            public byte preassign_lots = 0;

            public string attr_group = null;
            public string dimension_group = null;
            public string lot_attr_group = null;
            public byte track_pieces = 0;
            public Nullable<DateTime> bom_last_import_date = null;
            public byte save_current_rev_upon_bom_import = 0;

        }

        public class BillofMaterials : IComparable<BillofMaterials>
        {
            public List<BillItem> BOM { get; set; }

            public string BillHeader { get; set; }

            public int CompareTo(BillofMaterials other)
            {
                return BillHeader.CompareTo(other.BillHeader);
            }
        }
}
