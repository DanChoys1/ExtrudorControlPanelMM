using NPlot;
using Program;

namespace Extruder
{
    public partial class Form1 : Form
    {
        InitData initDatas = new InitData();

        QPT qpt = new QPT();
        DIE die = new DIE();

        public Form1()
        {
            InitializeComponent();

            InitQPT();
            InitDIE();
        }

        private void InitQPT()
        {
            //СВОЙСТВА ПОЛИМЕРНОГО МАТЕРИАЛА
            n.Value = (decimal)initDatas.data.m_;
            T0.Value = (decimal)initDatas.data.T0_;
            Mu0.Value = (decimal)initDatas.data.Mu0_;
            b.Value = (decimal)initDatas.data.b_;
            Ro.Value = (decimal)initDatas.data.Ro_;
            Ro_gr.Value = (decimal)initDatas.data.Ro_gran_;
            T_melt.Value = (decimal)initDatas.data.T_PL_;
            K_melt.Value = (decimal)initDatas.data.K_PL_;
            a.Value = (decimal)initDatas.data.a_T_;
            Lambda.Value = (decimal)initDatas.data.Lam_T_;

            //ОБЩИЕ ДАННЫЕ
            N_.Value = (decimal)initDatas.data.N_;
            T_start.Value = (decimal)initDatas.data.T_St;
            Alpha_b.Value = (decimal)initDatas.data.Al_kor;
            Alpha_s.Value = (decimal)initDatas.data.Al_scr;
            Lam_bar.Value = (decimal)initDatas.data.Lam_k;
            Lam_scr.Value = (decimal)initDatas.data.Lam_s;
            Variant.Value = (decimal)initDatas.data.Var_Tscr;
            T_scew.Value = (decimal)initDatas.data.T_scr;
            Delta_s.Value = (decimal)initDatas.data.Del_s;
            Al_med.Value = (decimal)initDatas.data.Al_W_s;
            T_med.Value = (decimal)initDatas.data.T_W_s;
            a_med.Value = (decimal)initDatas.data.a_W;
            Lam_med.Value = (decimal)initDatas.data.Lam_W;
            Q_med.Value = (decimal)initDatas.data.Q_W_s;
            n_Integ.Value = (decimal)initDatas.data.n_Integr;
            n_Graph.Value = (decimal)initDatas.data.n_Graph;

            //РЕЗЬБОВЫЕ СЕКЦИИ ВИНТОВ
            order1.Value = (decimal)initDatas.sect[0].Order;
            d_start1.Value = (decimal)initDatas.sect[0].D_st;
            d_final1.Value = (decimal)initDatas.sect[0].D_fin;
            l1.Value = (decimal)initDatas.sect[0].L_sect;
            rl1.Value = (decimal)initDatas.sect[0].R_or_L;
            i1.Value = (decimal)initDatas.sect[0].n_Line;
            step1.Value = (decimal)initDatas.sect[0].step_;
            h_start1.Value = (decimal)initDatas.sect[0].H_st;
            h_final1.Value = (decimal)initDatas.sect[0].H_fin;
            e_start1.Value = (decimal)initDatas.sect[0].e_st;
            e_final1.Value = (decimal)initDatas.sect[0].e_fin;
            delta1.Value = (decimal)initDatas.sect[0].delta;
            angle1.Value = (decimal)initDatas.sect[0].d_Fi;
            w_cut1.Value = (decimal)initDatas.sect[0].W_a;

            order2.Value = (decimal)initDatas.sect[1].Order;
            d_start2.Value = (decimal)initDatas.sect[1].D_st;
            d_final2.Value = (decimal)initDatas.sect[1].D_fin;
            l2.Value = (decimal)initDatas.sect[1].L_sect;
            rl2.Value = (decimal)initDatas.sect[1].R_or_L;
            i1.Value = (decimal)initDatas.sect[1].n_Line;
            step2.Value = (decimal)initDatas.sect[1].step_;
            h_start2.Value = (decimal)initDatas.sect[1].H_st;
            h_final2.Value = (decimal)initDatas.sect[1].H_fin;
            e_start2.Value = (decimal)initDatas.sect[1].e_st;
            e_final2.Value = (decimal)initDatas.sect[1].e_fin;
            delta2.Value = (decimal)initDatas.sect[1].delta;
            angle2.Value = (decimal)initDatas.sect[1].d_Fi;
            w_cut2.Value = (decimal)initDatas.sect[1].W_a;

            //ГЛАДКИЕ ВИНТОВЫЕ СЕКЦИИ
            order.Value = (decimal)initDatas.sect[2].Order;
            d_start.Value = (decimal)initDatas.sect[2].D_st;
            d_final.Value = (decimal)initDatas.sect[2].D_fin;
            l.Value = (decimal)initDatas.sect[2].L_sect;
            h_start.Value = (decimal)initDatas.sect[2].H_st;
            h_final.Value = (decimal)initDatas.sect[2].H_fin;
            k_integr.Value = (decimal)initDatas.sect[2].n_cykle;

            //СЕКЦИИ СТВОЛА 
            var_t_1.Value = (decimal)initDatas.cyl[0].Var_T;
            l_1.Value = (decimal)initDatas.cyl[0].L_sec;
            delta_1.Value = (decimal)initDatas.cyl[0].Del_k_;
            t_1.Value = (decimal)initDatas.cyl[0].T_W_k_;
            al_1.Value = (decimal)initDatas.cyl[0].Al_W_k_;
            a_1.Value = (decimal)initDatas.cyl[0].a_W_k_;
            lam_1.Value = (decimal)initDatas.cyl[0].Lam_W_k_;
            q_1.Value = (decimal)initDatas.cyl[0].Q_W_k_;

            var_t_2.Value = (decimal)initDatas.cyl[1].Var_T;
            l_2.Value = (decimal)initDatas.cyl[1].L_sec;
            delta_2.Value = (decimal)initDatas.cyl[1].Del_k_;
            t_2.Value = (decimal)initDatas.cyl[1].T_W_k_;
            al_2.Value = (decimal)initDatas.cyl[1].Al_W_k_;
            a_2.Value = (decimal)initDatas.cyl[1].a_W_k_;
            lam_2.Value = (decimal)initDatas.cyl[1].Lam_W_k_;
            q_2.Value = (decimal)initDatas.cyl[1].Q_W_k_;

            //ДОПОЛНИТЕЛЬНАЯ ИНФОРМАЦИЯ
            q_min_q_b.Value = (decimal)initDatas.dop.Alfa_min;
            q_max_q_b.Value = (decimal)initDatas.dop.Alfa_max;
            n_step.Value = (decimal)initDatas.dop.n_Alfa;
        }

        private void InitDIE()
        {
            //ОБЩИЕ ДАННЫЕ
            die_N_Alpha.Value = (decimal)initDatas.fluxData.N;
            die_N_r.Value = (decimal)initDatas.fluxData.iR;
            die_k1_Alpha.Value = (decimal)initDatas.fluxData.AH;
            die_k2_Alpha.Value = (decimal)initDatas.fluxData.AB;
            die_k1_r.Value = (decimal)initDatas.fluxData.kH;
            die_k2_r.Value = (decimal)initDatas.fluxData.kB;

            //РАЗДЕЛЫ ГОЛОВКИ
            die_priznak1.Value = (decimal)initDatas.S_K.S[0].PRIZNAK;
            die_order1.Value = (decimal)initDatas.S_K.S[0].Order;
            die_D_start1.Value = (decimal)initDatas.S_K.S[0].n_cykle;
            die_D_final1.Value = (decimal)initDatas.S_K.S[0].D_st;
            die_L1.Value = (decimal)initDatas.S_K.S[0].D_fin;
            die_T_st1.Value = (decimal)initDatas.S_K.S[0].D_B_st;
            die_k_integr1.Value = (decimal)initDatas.S_K.S[0].D_B_fin;
            die_D_VH_st1.Value = (decimal)initDatas.S_K.S[0].L_sect;
            die_D_VH_fn1.Value = (decimal)initDatas.S_K.S[0].T_st;
            die_T_VH1.Value = (decimal)initDatas.S_K.S[0].T_B;

            die_priznak2.Value = (decimal)initDatas.S_K.S[1].PRIZNAK;
            die_order2.Value = (decimal)initDatas.S_K.S[1].Order;
            die_D_start2.Value = (decimal)initDatas.S_K.S[1].n_cykle;
            die_D_final2.Value = (decimal)initDatas.S_K.S[1].D_st;
            die_L2.Value = (decimal)initDatas.S_K.S[1].D_fin;
            die_T_st2.Value = (decimal)initDatas.S_K.S[1].D_B_st;
            die_k_integr2.Value = (decimal)initDatas.S_K.S[1].D_B_fin;
            die_D_VH_st2.Value = (decimal)initDatas.S_K.S[1].L_sect;
            die_D_VH_fn2.Value = (decimal)initDatas.S_K.S[1].T_st;
            die_T_VH2.Value = (decimal)initDatas.S_K.S[1].T_B;

            die_priznak3.Value = (decimal)initDatas.S_K.S[2].PRIZNAK;
            die_order3.Value = (decimal)initDatas.S_K.S[2].Order;
            die_D_start3.Value = (decimal)initDatas.S_K.S[2].n_cykle;
            die_D_final3.Value = (decimal)initDatas.S_K.S[2].D_st;
            die_L3.Value = (decimal)initDatas.S_K.S[2].D_fin;
            die_T_st3.Value = (decimal)initDatas.S_K.S[2].D_B_st;
            die_k_integr3.Value = (decimal)initDatas.S_K.S[2].D_B_fin;
            die_D_VH_st3.Value = (decimal)initDatas.S_K.S[2].L_sect;
            die_D_VH_fn3.Value = (decimal)initDatas.S_K.S[2].T_st;
            die_T_VH3.Value = (decimal)initDatas.S_K.S[2].T_B;

            die_priznak4.Value = (decimal)initDatas.S_K.S[3].PRIZNAK;
            die_order4.Value = (decimal)initDatas.S_K.S[3].Order;
            die_D_start4.Value = (decimal)initDatas.S_K.S[3].n_cykle;
            die_D_final4.Value = (decimal)initDatas.S_K.S[3].D_st;
            die_L4.Value = (decimal)initDatas.S_K.S[3].D_fin;
            die_T_st4.Value = (decimal)initDatas.S_K.S[3].D_B_st;
            die_k_integr4.Value = (decimal)initDatas.S_K.S[3].D_B_fin;
            die_D_VH_st4.Value = (decimal)initDatas.S_K.S[3].L_sect;
            die_D_VH_fn4.Value = (decimal)initDatas.S_K.S[3].T_st;
            die_T_VH4.Value = (decimal)initDatas.S_K.S[3].T_B;

            die_Mu0.Value = (decimal)initDatas.res.Mu0;
            die_b.Value = (decimal)initDatas.res.b;
            die_n.Value = (decimal)initDatas.res.n;
            die_T0.Value = (decimal)initDatas.res.T0;
            die_a.Value = (decimal)initDatas.res.a;
            die_Lam.Value = (decimal)initDatas.res.Lam;
            die_n_Q.Value = (decimal)initDatas.res.n_Q;
            die_MQ1.Value = (decimal)initDatas.res.MQ[0];
            die_MQ2.Value = (decimal)initDatas.res.MQ[1];
            die_MQ3.Value = (decimal)initDatas.res.MQ[2];
            die_MP1.Value = (decimal)initDatas.res.MP[0];
            die_MP2.Value = (decimal)initDatas.res.MP[1];
            die_MP3.Value = (decimal)initDatas.res.MP[2];
            die_MT1.Value = (decimal)initDatas.res.MT[0];
            die_MT2.Value = (decimal)initDatas.res.MT[1];
            die_MT3.Value = (decimal)initDatas.res.MT[2];
        }

        private void InitDatasQPT()
        {
            initDatas.data.nS_1 = 2;
            initDatas.data.nS_2 = 1;
            initDatas.data.nS_korp = 2;

            //СВОЙСТВА ПОЛИМЕРНОГО МАТЕРИАЛА
            initDatas.data.m_ = (double)n.Value;
            initDatas.data.T0_ = (double)T0.Value;
            initDatas.data.Mu0_ = (double)Mu0.Value;
            initDatas.data.b_ = (double)b.Value;
            initDatas.data.Ro_ = (double)Ro.Value;
            initDatas.data.Ro_gran_ = (double)Ro_gr.Value;
            initDatas.data.T_PL_ = (double)T_melt.Value;
            initDatas.data.K_PL_ = (double)K_melt.Value;
            initDatas.data.a_T_ = (double)a.Value;
            initDatas.data.Lam_T_ = (double)Lambda.Value;

            //ОБЩИЕ ДАННЫЕ
            initDatas.data.N_ = (double)N_.Value;
            initDatas.data.T_St = (double)T_start.Value;
            initDatas.data.Al_kor = (double)Alpha_b.Value;
            initDatas.data.Al_scr = (double)Alpha_s.Value;
            initDatas.data.Lam_k = (double)Lam_bar.Value;
            initDatas.data.Lam_s = (double)Lam_scr.Value;
            initDatas.data.Var_Tscr = (int)Variant.Value;
            initDatas.data.T_scr = (double)T_scew.Value;
            initDatas.data.Del_s = (double)Delta_s.Value;
            initDatas.data.Al_W_s = (double)Al_med.Value;
            initDatas.data.T_W_s = (double)T_med.Value;
            initDatas.data.a_W = (double)a_med.Value;
            initDatas.data.Lam_W = (double)Lam_med.Value;
            initDatas.data.Q_W_s = (double)Q_med.Value;
            initDatas.data.n_Integr = (int)n_Integ.Value;
            initDatas.data.n_Graph = (int)n_Graph.Value;

            //РЕЗЬБОВЫЕ СЕКЦИИ ВИНТОВ
            initDatas.sect[0].Order = (int)order1.Value;
            initDatas.sect[0].D_st = (double)d_start1.Value;
            initDatas.sect[0].D_fin = (double)d_final1.Value;
            initDatas.sect[0].L_sect = (double)l1.Value;
            initDatas.sect[0].R_or_L = (int)rl1.Value;
            initDatas.sect[0].n_Line = (int)i1.Value;
            initDatas.sect[0].step_ = (double)step1.Value;
            initDatas.sect[0].H_st = (double)h_start1.Value;
            initDatas.sect[0].H_fin = (double)h_final1.Value;
            initDatas.sect[0].e_st = (double)e_start1.Value;
            initDatas.sect[0].e_fin = (double)e_final1.Value;
            initDatas.sect[0].delta = (double)delta1.Value;
            initDatas.sect[0].d_Fi = (double)angle1.Value;
            initDatas.sect[0].W_a = (double)w_cut1.Value;

            initDatas.sect[1].Order = (int)order2.Value;
            initDatas.sect[1].D_st = (double)d_start2.Value;
            initDatas.sect[1].D_fin = (double)d_final2.Value;
            initDatas.sect[1].L_sect = (double)l2.Value;
            initDatas.sect[1].R_or_L = (int)rl2.Value;
            initDatas.sect[1].n_Line = (int)i1.Value;
            initDatas.sect[1].step_ = (double)step2.Value;
            initDatas.sect[1].H_st = (double)h_start2.Value;
            initDatas.sect[1].H_fin = (double)h_final2.Value;
            initDatas.sect[1].e_st = (double)e_start2.Value;
            initDatas.sect[1].e_fin = (double)e_final2.Value;
            initDatas.sect[1].delta = (double)delta2.Value;
            initDatas.sect[1].d_Fi = (double)angle2.Value;
            initDatas.sect[1].W_a = (double)w_cut2.Value;

            //ГЛАДКИЕ ВИНТОВЫЕ СЕКЦИИ
            initDatas.sect[2].Order = (int)order.Value;
            initDatas.sect[2].D_st = (double)d_start.Value;
            initDatas.sect[2].D_fin = (double)d_final.Value;
            initDatas.sect[2].L_sect = (double)l.Value;
            initDatas.sect[2].H_st = (double)h_start.Value;
            initDatas.sect[2].H_fin = (double)h_final.Value;
            initDatas.sect[2].n_cykle = (int)k_integr.Value;

            //СЕКЦИИ СТВОЛА
            initDatas.cyl[0].Var_T = (int)var_t_1.Value;
            initDatas.cyl[0].L_sec = (double)l_1.Value;
            initDatas.cyl[0].Del_k_ = (double)delta_1.Value;
            initDatas.cyl[0].T_W_k_ = (double)t_1.Value;
            initDatas.cyl[0].Al_W_k_ = (double)al_1.Value;
            initDatas.cyl[0].a_W_k_ = (double)a_1.Value;
            initDatas.cyl[0].Lam_W_k_ = (double)lam_1.Value;
            initDatas.cyl[0].Q_W_k_ = (double)q_1.Value;

            initDatas.cyl[1].Var_T = (int)var_t_2.Value;
            initDatas.cyl[1].L_sec = (double)l_2.Value;
            initDatas.cyl[1].Del_k_ = (double)delta_2.Value;
            initDatas.cyl[1].T_W_k_ = (double)t_2.Value;
            initDatas.cyl[1].Al_W_k_ = (double)al_2.Value;
            initDatas.cyl[1].a_W_k_ = (double)a_2.Value;
            initDatas.cyl[1].Lam_W_k_ = (double)lam_2.Value;
            initDatas.cyl[1].Q_W_k_ = (double)q_2.Value;

            //ДОПОЛНИТЕЛЬНАЯ ИНФОРМАЦИЯ
            initDatas.dop.Alfa_min = (double)q_min_q_b.Value;
            initDatas.dop.Alfa_max = (double)q_max_q_b.Value;
            initDatas.dop.n_Alfa = (int)n_step.Value;
        }

        private void InitDatasDIE()
        {
            //РАСЧИТАННЫЕ В QPT
            initDatas.res.Mu0 = (double)die_Mu0.Value;
            initDatas.res.b = (double)die_b.Value;
            initDatas.res.n = (double)die_n.Value;
            initDatas.res.T0 = (double)die_T0.Value;
            initDatas.res.a = (double)die_a.Value;
            initDatas.res.Lam = (double)die_Lam.Value;
            initDatas.res.n_Q = (int)die_n_Q.Value;
            initDatas.res.MQ[0] = (double)die_MQ1.Value;
            initDatas.res.MQ[1] = (double)die_MQ2.Value;
            initDatas.res.MQ[2] = (double)die_MQ3.Value;
            initDatas.res.MP[0] = (double)die_MP1.Value;
            initDatas.res.MP[1] = (double)die_MP2.Value;
            initDatas.res.MP[2] = (double)die_MP3.Value;
            initDatas.res.MT[0] = (double)die_MT1.Value;
            initDatas.res.MT[1] = (double)die_MT2.Value;
            initDatas.res.MT[2] = (double)die_MT3.Value;

            initDatas.fluxData.N = (int)die_N_Alpha.Value;
            initDatas.fluxData.iR = (int)die_N_r.Value;
            initDatas.fluxData.AH = (double)die_k1_Alpha.Value;
            initDatas.fluxData.AB = (double)die_k2_Alpha.Value;
            initDatas.fluxData.kH = (double)die_k1_r.Value;
            initDatas.fluxData.kB = (double)die_k2_r.Value;

            initDatas.S_K.S[0].PRIZNAK = (int)die_priznak1.Value;
            initDatas.S_K.S[0].Order = (int)die_order1.Value;
            initDatas.S_K.S[0].n_cykle = (int)die_D_start1.Value;
            initDatas.S_K.S[0].D_st = (double)die_D_final1.Value;
            initDatas.S_K.S[0].D_fin = (double)die_L1.Value;
            initDatas.S_K.S[0].D_B_st = (double)die_T_st1.Value;
            initDatas.S_K.S[0].D_B_fin = (double)die_k_integr1.Value;
            initDatas.S_K.S[0].L_sect = (double)die_D_VH_st1.Value;
            initDatas.S_K.S[0].T_st = (double)die_D_VH_fn1.Value;
            initDatas.S_K.S[0].T_B = (double)die_T_VH1.Value;

            initDatas.S_K.S[1].PRIZNAK = (int)die_priznak2.Value;
            initDatas.S_K.S[1].Order = (int)die_order2.Value;
            initDatas.S_K.S[1].n_cykle = (int)die_D_start2.Value;
            initDatas.S_K.S[1].D_st = (double)die_D_final2.Value;
            initDatas.S_K.S[1].D_fin = (double)die_L2.Value;
            initDatas.S_K.S[1].D_B_st = (double)die_T_st2.Value;
            initDatas.S_K.S[1].D_B_fin = (double)die_k_integr2.Value;
            initDatas.S_K.S[1].L_sect = (double)die_D_VH_st2.Value;
            initDatas.S_K.S[1].T_st = (double)die_D_VH_fn2.Value;
            initDatas.S_K.S[1].T_B = (double)die_T_VH2.Value;

            initDatas.S_K.S[2].PRIZNAK = (int)die_priznak3.Value;
            initDatas.S_K.S[2].Order = (int)die_order3.Value;
            initDatas.S_K.S[2].n_cykle = (int)die_D_start3.Value;
            initDatas.S_K.S[2].D_st = (double)die_D_final3.Value;
            initDatas.S_K.S[2].D_fin = (double)die_L3.Value;
            initDatas.S_K.S[2].D_B_st = (double)die_T_st3.Value;
            initDatas.S_K.S[2].D_B_fin = (double)die_k_integr3.Value;
            initDatas.S_K.S[2].L_sect = (double)die_D_VH_st3.Value;
            initDatas.S_K.S[2].T_st = (double)die_D_VH_fn3.Value;
            initDatas.S_K.S[2].T_B = (double)die_T_VH3.Value;

            initDatas.S_K.S[3].PRIZNAK = (int)die_priznak4.Value;
            initDatas.S_K.S[3].Order = (int)die_order4.Value;
            initDatas.S_K.S[3].n_cykle = (int)die_D_start4.Value;
            initDatas.S_K.S[3].D_st = (double)die_D_final4.Value;
            initDatas.S_K.S[3].D_fin = (double)die_L4.Value;
            initDatas.S_K.S[3].D_B_st = (double)die_T_st4.Value;
            initDatas.S_K.S[3].D_B_fin = (double)die_k_integr4.Value;
            initDatas.S_K.S[3].L_sect = (double)die_D_VH_st4.Value;
            initDatas.S_K.S[3].T_st = (double)die_D_VH_fn4.Value;
            initDatas.S_K.S[3].T_B = (double)die_T_VH4.Value;
        }

        private void WriteQPTResToInitData()
        {
            die_Mu0.Value = (decimal)qpt.Res.Mu0;
            die_b.Value = (decimal)qpt.Res.b;
            die_n.Value = (decimal)qpt.Res.n;
            die_T0.Value = (decimal)qpt.Res.T0;
            die_a.Value = (decimal)qpt.Res.a;
            die_Lam.Value = (decimal)qpt.Res.Lam;
            die_n_Q.Value = (decimal)qpt.Res.n_Q;
            die_MQ1.Value = (decimal)qpt.Res.MQ[0];
            die_MQ2.Value = (decimal)qpt.Res.MQ[1];
            die_MQ3.Value = (decimal)qpt.Res.MQ[2];
            die_MP1.Value = (decimal)qpt.Res.MP[0];
            die_MP2.Value = (decimal)qpt.Res.MP[1];
            die_MP3.Value = (decimal)qpt.Res.MP[2];
            die_MT1.Value = (decimal)qpt.Res.MT[0];
            die_MT2.Value = (decimal)qpt.Res.MT[1];
            die_MT3.Value = (decimal)qpt.Res.MT[2];
        }

        private void button1_Click(object sender, EventArgs e)
        {
            InitDatasQPT();

            qpt.init(initDatas);
            table.Text = qpt.table;

            WriteQPTResToInitData();

            paintQPTGraphs();

            tabs.SelectedIndex = 1;
        }
        private void button2_Click(object sender, EventArgs e)
        {
            InitDatasDIE();

            die.init(initDatas);
            dieTable.Text = die.table;

            paintDIEGraphs();

            tabs.SelectedIndex = 3;
        }

        void paintQPTGraphs()
        {
            pictureBoxFluent11.Image = paintPlot(qpt.ZM_LIST[0], 1e3, pictureBoxFluent11.Width, "Координата оси винта, мм",
                                                 qpt.PM_LIST[0], 1, pictureBoxFluent11.Height, "",
                                                 qpt.k, "удельное давление",
                                                 "Плавное удельное давление, температура расплавленного полимера\n" +
                                                 "и ширина твердой фазы");
            pictureBoxFluent12.Image = paintPlot(qpt.ZM_LIST[0], 1e3, pictureBoxFluent12.Width, "Координата оси винта, мм",
                                                 qpt.TM_LIST[0], 1, pictureBoxFluent12.Height, "",
                                                 qpt.k, "температура",
                                                 "Плавное удельное давление, температура расплавленного полимера\n" +
                                                 "и ширина твердой фазы");
            pictureBoxFluent13.Image = paintPlot(qpt.ZM_LIST[0], 1e3, pictureBoxFluent13.Width, "Координата оси винта, мм",
                                                 qpt.X_OTN_LIST[0], 1, pictureBoxFluent13.Height, "",
                                                 qpt.k, "ширина твердой фазы",
                                                 "Плавное удельное давление, температура расплавленного полимера\n" +
                                                 "и ширина твердой фазы");

            pictureBoxFluent21.Image = paintPlot(qpt.ZM_LIST[1], 1e3, pictureBoxFluent21.Width, "Координата оси винта, мм",
                                                 qpt.PM_LIST[1], 1, pictureBoxFluent21.Height, "",
                                                 qpt.k, "удельное давление",
                                                 "Плавное удельное давление, температура расплавленного полимера\n" +
                                                 "и ширина твердой фазы");
            pictureBoxFluent22.Image = paintPlot(qpt.ZM_LIST[1], 1e3, pictureBoxFluent22.Width, "Координата оси винта, мм",
                                                 qpt.TM_LIST[1], 1, pictureBoxFluent22.Height, "",
                                                 qpt.k, "температура",
                                                 "Плавное удельное давление, температура расплавленного полимера\n" +
                                                 "и ширина твердой фазы");
            pictureBoxFluent23.Image = paintPlot(qpt.ZM_LIST[1], 1e3, pictureBoxFluent23.Width, "Координата оси винта, мм",
                                                 qpt.X_OTN_LIST[1], 1, pictureBoxFluent23.Height, "",
                                                 qpt.k, "ширина твердой фазы",
                                                 "Плавное удельное давление, температура расплавленного полимера\n" +
                                                 "и ширина твердой фазы");

            pictureBoxFluent31.Image = paintPlot(qpt.ZM_LIST[2], 1e3, pictureBoxFluent31.Width, "Координата оси винта, мм",
                                                  qpt.PM_LIST[2], 1, pictureBoxFluent31.Height, "",
                                                  qpt.k, "удельное давление",
                                                  "Плавное удельное давление, температура расплавленного полимера\n" +
                                                  "и ширина твердой фазы");
            pictureBoxFluent32.Image = paintPlot(qpt.ZM_LIST[2], 1e3, pictureBoxFluent32.Width, "Координата оси винта, мм",
                                                 qpt.TM_LIST[2], 1, pictureBoxFluent32.Height, "",
                                                 qpt.k, "температура",
                                                 "Плавное удельное давление, температура расплавленного полимера\n" +
                                                 "и ширина твердой фазы");
            pictureBoxFluent33.Image = paintPlot(qpt.ZM_LIST[2], 1e3, pictureBoxFluent33.Width, "Координата оси винта, мм",
                                                 qpt.X_OTN_LIST[2], 1, pictureBoxFluent33.Height, "",
                                                 qpt.k, "ширина твердой фазы",
                                                 "Плавное удельное давление, температура расплавленного полимера\n" +
                                                 "и ширина твердой фазы");

            pictureBox4.Image = paintPlot(qpt.Res.MQ, 1e2, pictureBox4.Width, "Q, sm^3/sec, * 1e2",
                                          qpt.Res.MP, 1, pictureBox4.Height, "p, MPa",
                                          qpt.DOP.n_Alfa, "",
                                          "ВЛИЯНИЕ ОБЪЕМНОГО РАСХОДА ПОЛИМЕРНОГО МАТЕРИАЛА\n" +
                                          "НА УДЕЛЬНОЕ ДАВЛЕНИЕ ПЕРЕД ФОРМУЮЩЕЙ ГОЛОВКОЙ");
            pictureBox5.Image = paintPlot(qpt.Res.MQ, 1e2, pictureBox5.Width, "Q, sm^3/sec, * 1e2",
                                          qpt.Res.MT, 1, pictureBox5.Height, "T, grad.C",
                                          qpt.DOP.n_Alfa, "",
                                          "ВЛИЯНИЕ ОБЪЕМНОГО РАСХОДА НА ТЕМПЕРАТУРУ\n" +
                                          "ПОЛИМЕРА ПЕРЕД ФОРМУЮЩЕЙ ГОЛОВКОЙ");
        }

        void paintDIEGraphs()
        {
            pictureBox12.Image = paintPlot(die.SD, 1e-2, pictureBox12.Width, "GAMMA, 1/c, * 1e-2",
                                           die.TAU, 1, pictureBox12.Height, "TAU, kPa",
                                           die.KT, "", "");
            pictureBox13.Image = paintPlot(die.R2, 1e4, pictureBox13.Width, "r, m, * 1e4",
                                           die.Gamma, 1, pictureBox13.Height, "GAMMA, 1/sec",
                                           die.DAT.N, "", "");
            pictureBox14.Image = paintPlot(die.RR, 1e4, pictureBox14.Width, "r, m, * 1e4",
                                           die.VZ, 1e3, pictureBox14.Height, "Vz, m/sec, * 1e3",
                                           die.DAT.iR, "", "");
            pictureBox15.Image = paintPlot(die.R2, 1e4, pictureBox15.Width, "r, m, * 1e4",
                                           die.T, 1, pictureBox15.Height, "T, gr*C",
                                           die.DAT.N, "", "");

            pictureBox16.Image = paintPlot(die.M_Q, 1e2, pictureBox16.Width, "Q, sm^3/sec, * 1e2",
                                           die.Res.MP, 1, pictureBox16.Height, "p, MPa",
                                           die.Res.n_Q, "for a scrue",
                                           die.M_Q, 1e2,
                                           die.M_P, 1,
                                           die.Res.n_Q, "for a head",
                                           "Зависимость между удельным давлением «p» перед головкой и\n" +
                                           "объёмной пропускной способностью «q»");
            pictureBox17.Image = paintPlot(die.M_Q, 1e2, pictureBox17.Width, "Q, sm^3/sec, * 1e2",
                                           die.Res.MT, 1, pictureBox17.Height, "T, grad.C",
                                           die.Res.n_Q, "in front of a head",
                                           die.M_Q, 1e2,
                                           die.T_out, 1,
                                           die.Res.n_Q, "at the exit of a head",
                                           "Зависимость температуры полимера перед головкой и\n" +
                                           "на ее выходе от производительности экструдера");
        }

        public void paint(double[] x, double coeffX, double xSt, double xFn, double w,
                          double[] y, double coeffY, double ySt, double yFn, double h,
                          int countPoints, Graphics gr)
        {
            if (countPoints == 0) return;

            float xS = (float)(w / (xFn - xSt));
            float yS = (float)(h / (yFn - ySt));

            PointF[] points = new PointF[countPoints + 1];

            for (int i = 0; i <= countPoints; i++)
            {
                points[i] = new PointF((float)((x[i] * coeffX - xSt) * xS),
                                       (float)(h - (y[i] * coeffY - ySt) * yS));
            }

            gr.DrawLines(new Pen(Color.Green, 3f), points);
        }

        private Bitmap paintPlot(double[] x, double coeffX, double w, string xLabel,
                                 double[] y, double coeffY, double h, string yLabel,
                                 int countPoints, string plotLabel = "", string title = "")
        {
            NPlot.Bitmap.PlotSurface2D npSurface = new NPlot.Bitmap.PlotSurface2D((int)w, (int)h);
            npSurface.Clear();
            npSurface.Title = title;
            npSurface.BackColor = System.Drawing.Color.White;

            double[] X1 = new double[countPoints + 1];
            double[] Y1 = new double[countPoints + 1];

            for (int i = 0; i <= countPoints; i++)
            {
                X1[i] = x[i] * coeffX;
                Y1[i] = y[i] * coeffY;
            }

            NPlot.LinePlot linePlot = new LinePlot();
            linePlot.AbscissaData = X1;
            linePlot.DataSource = Y1;
            linePlot.Label = plotLabel;
            linePlot.Color = System.Drawing.Color.Blue;

            NPlot.PointPlot pointPlot = new PointPlot();
            pointPlot.AbscissaData = X1;
            pointPlot.DataSource = Y1;
            pointPlot.Marker.Color = System.Drawing.Color.Blue;

            npSurface.Add(linePlot, NPlot.PlotSurface2D.XAxisPosition.Bottom,
                                    NPlot.PlotSurface2D.YAxisPosition.Left);
            npSurface.Add(pointPlot, NPlot.PlotSurface2D.XAxisPosition.Bottom,
                                     NPlot.PlotSurface2D.YAxisPosition.Left);

            npSurface.XAxis1.Label = xLabel;
            npSurface.YAxis1.Label = yLabel;

            NPlot.Legend npLegend = new NPlot.Legend();
            npLegend.AttachTo(NPlot.PlotSurface2D.XAxisPosition.Top,
                              NPlot.PlotSurface2D.YAxisPosition.Right);
            npLegend.VerticalEdgePlacement = NPlot.Legend.Placement.Inside;
            npLegend.HorizontalEdgePlacement = NPlot.Legend.Placement.Outside;
            npLegend.BorderStyle = NPlot.LegendBase.BorderType.Line;
            npSurface.Legend = npLegend;

            npSurface.Refresh();

            return npSurface.Bitmap;
        }

        private Bitmap paintPlot(double[] x, double coeffX, double w, string xLabel,
                                 double[] y, double coeffY, double h, string yLabel,
                                 int countPoints1, string plotLabel1,
                                 double[] x2, double coeffX2,
                                 double[] y2, double coeffY2,
                                 int countPoints2, string plotLabel2,
                                 string title = "")
        {
            NPlot.Bitmap.PlotSurface2D npSurface = new NPlot.Bitmap.PlotSurface2D((int)w, (int)h);
            npSurface.Clear();
            npSurface.Title = title;
            npSurface.BackColor = System.Drawing.Color.White;

            double[] X1 = new double[countPoints1 + 1];
            double[] Y1 = new double[countPoints1 + 1];
            double[] X2 = new double[countPoints2 + 1];
            double[] Y2 = new double[countPoints2 + 1];

            for (int i = 0; i <= countPoints1; i++)
            {
                X1[i] = x[i] * coeffX;
                Y1[i] = y[i] * coeffY;
            }
            for (int i = 0; i <= countPoints2; i++)
            {
                X2[i] = x2[i] * coeffX2;
                Y2[i] = y2[i] * coeffY2;
            }

            //XY1
            NPlot.LinePlot linePlot = new LinePlot();
            linePlot.AbscissaData = X1;
            linePlot.DataSource = Y1;
            linePlot.Label = plotLabel1;
            linePlot.Color = System.Drawing.Color.Blue;

            NPlot.PointPlot pointPlot = new PointPlot();
            pointPlot.AbscissaData = X1;
            pointPlot.DataSource = Y1;
            pointPlot.Marker.Color = System.Drawing.Color.Blue;

            npSurface.Add(linePlot, NPlot.PlotSurface2D.XAxisPosition.Bottom,
                                    NPlot.PlotSurface2D.YAxisPosition.Left);
            npSurface.Add(pointPlot, NPlot.PlotSurface2D.XAxisPosition.Bottom,
                                     NPlot.PlotSurface2D.YAxisPosition.Left);

            //XY2
            NPlot.LinePlot linePlot2 = new LinePlot();
            linePlot2.AbscissaData = X2;
            linePlot2.DataSource = Y2;
            linePlot2.Label = plotLabel2;
            linePlot2.Color = System.Drawing.Color.Green;

            NPlot.PointPlot pointPlot2 = new PointPlot();
            pointPlot2.AbscissaData = X2;
            pointPlot2.DataSource = Y2;
            pointPlot2.Marker.Color = System.Drawing.Color.Green;

            npSurface.Add(linePlot2, NPlot.PlotSurface2D.XAxisPosition.Bottom,
                                     NPlot.PlotSurface2D.YAxisPosition.Left);
            npSurface.Add(pointPlot2, NPlot.PlotSurface2D.XAxisPosition.Bottom,
                                      NPlot.PlotSurface2D.YAxisPosition.Left);

            npSurface.XAxis1.Label = xLabel;
            npSurface.YAxis1.Label = yLabel;

            NPlot.Legend npLegend = new NPlot.Legend();
            npLegend.AttachTo(NPlot.PlotSurface2D.XAxisPosition.Top,
                              NPlot.PlotSurface2D.YAxisPosition.Right);
            npLegend.VerticalEdgePlacement = NPlot.Legend.Placement.Inside;
            npLegend.HorizontalEdgePlacement = NPlot.Legend.Placement.Outside;
            npLegend.BorderStyle = NPlot.LegendBase.BorderType.Line;
            npSurface.Legend = npLegend;

            npSurface.Refresh();

            return npSurface.Bitmap;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            QPT_DIE_Adapter adapter = new QPT_DIE_Adapter();
            adapter.init(initDatas);
            QPT_DIE_Res_label.Text = "QPT\n" + adapter.qpt.table + '\n' + "DIE\n" + adapter.die.table;
            tabs.SelectedIndex = 5;
        }
    }
}