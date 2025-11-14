using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F069116 - .
/// </summary>
public class F069116 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// YCANN8.
        /// </summary>
        public const string YCANN8 = "YCANN8";

        /// <summary>
        /// YCEXA.
        /// </summary>
        public const string YCEXA = "YCEXA";

        /// <summary>
        /// YCDC.
        /// </summary>
        public const string YCDC = "YCDC";

        /// <summary>
        /// YCPGRP.
        /// </summary>
        public const string YCPGRP = "YCPGRP";

        /// <summary>
        /// YCPAYG.
        /// </summary>
        public const string YCPAYG = "YCPAYG";

        /// <summary>
        /// YCPAYN.
        /// </summary>
        public const string YCPAYN = "YCPAYN";

        /// <summary>
        /// YCDTAB.
        /// </summary>
        public const string YCDTAB = "YCDTAB";

        /// <summary>
        /// YCSPW2.
        /// </summary>
        public const string YCSPW2 = "YCSPW2";

        /// <summary>
        /// YCPB.
        /// </summary>
        public const string YCPB = "YCPB";

        /// <summary>
        /// YCDESQ.
        /// </summary>
        public const string YCDESQ = "YCDESQ";

        /// <summary>
        /// YCMV.
        /// </summary>
        public const string YCMV = "YCMV";

        /// <summary>
        /// YCDISO.
        /// </summary>
        public const string YCDISO = "YCDISO";

        /// <summary>
        /// YCPDBA.
        /// </summary>
        public const string YCPDBA = "YCPDBA";

        /// <summary>
        /// YCPCK.
        /// </summary>
        public const string YCPCK = "YCPCK";

        /// <summary>
        /// YCDEDM.
        /// </summary>
        public const string YCDEDM = "YCDEDM";

        /// <summary>
        /// YCUM.
        /// </summary>
        public const string YCUM = "YCUM";

        /// <summary>
        /// YCRTAM.
        /// </summary>
        public const string YCRTAM = "YCRTAM";

        /// <summary>
        /// YCPAYM.
        /// </summary>
        public const string YCPAYM = "YCPAYM";

        /// <summary>
        /// YCSHD.
        /// </summary>
        public const string YCSHD = "YCSHD";

        /// <summary>
        /// YCCMTH.
        /// </summary>
        public const string YCCMTH = "YCCMTH";

        /// <summary>
        /// YCPPDL.
        /// </summary>
        public const string YCPPDL = "YCPPDL";

        /// <summary>
        /// YCMDL.
        /// </summary>
        public const string YCMDL = "YCMDL";

        /// <summary>
        /// YCADL.
        /// </summary>
        public const string YCADL = "YCADL";

        /// <summary>
        /// YCPPPL.
        /// </summary>
        public const string YCPPPL = "YCPPPL";

        /// <summary>
        /// YCNP.
        /// </summary>
        public const string YCNP = "YCNP";

        /// <summary>
        /// YCAD.
        /// </summary>
        public const string YCAD = "YCAD";

        /// <summary>
        /// YCACO.
        /// </summary>
        public const string YCACO = "YCACO";

        /// <summary>
        /// YCAI.
        /// </summary>
        public const string YCAI = "YCAI";

        /// <summary>
        /// YCHMIN.
        /// </summary>
        public const string YCHMIN = "YCHMIN";

        /// <summary>
        /// YCHMAX.
        /// </summary>
        public const string YCHMAX = "YCHMAX";

        /// <summary>
        /// YCIIAP.
        /// </summary>
        public const string YCIIAP = "YCIIAP";

        /// <summary>
        /// YCDEP1.
        /// </summary>
        public const string YCDEP1 = "YCDEP1";

        /// <summary>
        /// YCDEP2.
        /// </summary>
        public const string YCDEP2 = "YCDEP2";

        /// <summary>
        /// YCDEP3.
        /// </summary>
        public const string YCDEP3 = "YCDEP3";

        /// <summary>
        /// YCDEP4.
        /// </summary>
        public const string YCDEP4 = "YCDEP4";

        /// <summary>
        /// YCDEP5.
        /// </summary>
        public const string YCDEP5 = "YCDEP5";

        /// <summary>
        /// YCDEP6.
        /// </summary>
        public const string YCDEP6 = "YCDEP6";

        /// <summary>
        /// YCTT01.
        /// </summary>
        public const string YCTT01 = "YCTT01";

        /// <summary>
        /// YCTT02.
        /// </summary>
        public const string YCTT02 = "YCTT02";

        /// <summary>
        /// YCTT03.
        /// </summary>
        public const string YCTT03 = "YCTT03";

        /// <summary>
        /// YCTT04.
        /// </summary>
        public const string YCTT04 = "YCTT04";

        /// <summary>
        /// YCTT05.
        /// </summary>
        public const string YCTT05 = "YCTT05";

        /// <summary>
        /// YCTT06.
        /// </summary>
        public const string YCTT06 = "YCTT06";

        /// <summary>
        /// YCTT07.
        /// </summary>
        public const string YCTT07 = "YCTT07";

        /// <summary>
        /// YCTT08.
        /// </summary>
        public const string YCTT08 = "YCTT08";

        /// <summary>
        /// YCTT09.
        /// </summary>
        public const string YCTT09 = "YCTT09";

        /// <summary>
        /// YCTT10.
        /// </summary>
        public const string YCTT10 = "YCTT10";

        /// <summary>
        /// YCTT11.
        /// </summary>
        public const string YCTT11 = "YCTT11";

        /// <summary>
        /// YCTT12.
        /// </summary>
        public const string YCTT12 = "YCTT12";

        /// <summary>
        /// YCTT13.
        /// </summary>
        public const string YCTT13 = "YCTT13";

        /// <summary>
        /// YCTT14.
        /// </summary>
        public const string YCTT14 = "YCTT14";

        /// <summary>
        /// YCTT15.
        /// </summary>
        public const string YCTT15 = "YCTT15";

        /// <summary>
        /// YCNMTH.
        /// </summary>
        public const string YCNMTH = "YCNMTH";

        /// <summary>
        /// YCPDED.
        /// </summary>
        public const string YCPDED = "YCPDED";

        /// <summary>
        /// YCDPRI.
        /// </summary>
        public const string YCDPRI = "YCDPRI";

        /// <summary>
        /// YCDGRP.
        /// </summary>
        public const string YCDGRP = "YCDGRP";

        /// <summary>
        /// YCDBAL.
        /// </summary>
        public const string YCDBAL = "YCDBAL";

        /// <summary>
        /// YCARRR.
        /// </summary>
        public const string YCARRR = "YCARRR";

        /// <summary>
        /// YCNPER.
        /// </summary>
        public const string YCNPER = "YCNPER";

        /// <summary>
        /// YCSVCD.
        /// </summary>
        public const string YCSVCD = "YCSVCD";

        /// <summary>
        /// YCQDL.
        /// </summary>
        public const string YCQDL = "YCQDL";

        /// <summary>
        /// YCSVH.
        /// </summary>
        public const string YCSVH = "YCSVH";

        /// <summary>
        /// YCAAF.
        /// </summary>
        public const string YCAAF = "YCAAF";

        /// <summary>
        /// YCPTCT.
        /// </summary>
        public const string YCPTCT = "YCPTCT";

        /// <summary>
        /// YCCPE.
        /// </summary>
        public const string YCCPE = "YCCPE";

        /// <summary>
        /// YCEFTB.
        /// </summary>
        public const string YCEFTB = "YCEFTB";

        /// <summary>
        /// YCEFTE.
        /// </summary>
        public const string YCEFTE = "YCEFTE";

        /// <summary>
        /// YCACEQ.
        /// </summary>
        public const string YCACEQ = "YCACEQ";

        /// <summary>
        /// YCSADL.
        /// </summary>
        public const string YCSADL = "YCSADL";

        /// <summary>
        /// YCSDED.
        /// </summary>
        public const string YCSDED = "YCSDED";

        /// <summary>
        /// YCAMTS.
        /// </summary>
        public const string YCAMTS = "YCAMTS";

        /// <summary>
        /// YCPR01.
        /// </summary>
        public const string YCPR01 = "YCPR01";

        /// <summary>
        /// YCPR02.
        /// </summary>
        public const string YCPR02 = "YCPR02";

        /// <summary>
        /// YCPR03.
        /// </summary>
        public const string YCPR03 = "YCPR03";

        /// <summary>
        /// YCPR04.
        /// </summary>
        public const string YCPR04 = "YCPR04";

        /// <summary>
        /// YCPR05.
        /// </summary>
        public const string YCPR05 = "YCPR05";

        /// <summary>
        /// YCTASF.
        /// </summary>
        public const string YCTASF = "YCTASF";

        /// <summary>
        /// YCTRPF.
        /// </summary>
        public const string YCTRPF = "YCTRPF";

        /// <summary>
        /// YCSALY.
        /// </summary>
        public const string YCSALY = "YCSALY";

        /// <summary>
        /// YCCOVA.
        /// </summary>
        public const string YCCOVA = "YCCOVA";

        /// <summary>
        /// YCTRID.
        /// </summary>
        public const string YCTRID = "YCTRID";

        /// <summary>
        /// YCTYST.
        /// </summary>
        public const string YCTYST = "YCTYST";

        /// <summary>
        /// YCBENF.
        /// </summary>
        public const string YCBENF = "YCBENF";

        /// <summary>
        /// YCPPPM.
        /// </summary>
        public const string YCPPPM = "YCPPPM";

        /// <summary>
        /// YCEPRI.
        /// </summary>
        public const string YCEPRI = "YCEPRI";

        /// <summary>
        /// YCPTER.
        /// </summary>
        public const string YCPTER = "YCPTER";

        /// <summary>
        /// YCSTAB.
        /// </summary>
        public const string YCSTAB = "YCSTAB";

        /// <summary>
        /// YCCMAX.
        /// </summary>
        public const string YCCMAX = "YCCMAX";

        /// <summary>
        /// YCRTAB.
        /// </summary>
        public const string YCRTAB = "YCRTAB";

        /// <summary>
        /// YCTARA.
        /// </summary>
        public const string YCTARA = "YCTARA";

        /// <summary>
        /// YCHMCO.
        /// </summary>
        public const string YCHMCO = "YCHMCO";

        /// <summary>
        /// YCPGM1.
        /// </summary>
        public const string YCPGM1 = "YCPGM1";

        /// <summary>
        /// YCPGM2.
        /// </summary>
        public const string YCPGM2 = "YCPGM2";

        /// <summary>
        /// YCTDBA.
        /// </summary>
        public const string YCTDBA = "YCTDBA";

        /// <summary>
        /// YCCMHU.
        /// </summary>
        public const string YCCMHU = "YCCMHU";

        /// <summary>
        /// YCBDT.
        /// </summary>
        public const string YCBDT = "YCBDT";

        /// <summary>
        /// YCDBAS.
        /// </summary>
        public const string YCDBAS = "YCDBAS";

        /// <summary>
        /// YCUDBA.
        /// </summary>
        public const string YCUDBA = "YCUDBA";

        /// <summary>
        /// YCAIGR.
        /// </summary>
        public const string YCAIGR = "YCAIGR";

        /// <summary>
        /// YCPR06.
        /// </summary>
        public const string YCPR06 = "YCPR06";

        /// <summary>
        /// YCPR07.
        /// </summary>
        public const string YCPR07 = "YCPR07";

        /// <summary>
        /// YCPR08.
        /// </summary>
        public const string YCPR08 = "YCPR08";

        /// <summary>
        /// YCPR09.
        /// </summary>
        public const string YCPR09 = "YCPR09";

        /// <summary>
        /// YCPR10.
        /// </summary>
        public const string YCPR10 = "YCPR10";

        /// <summary>
        /// YCPR11.
        /// </summary>
        public const string YCPR11 = "YCPR11";

        /// <summary>
        /// YCPR12.
        /// </summary>
        public const string YCPR12 = "YCPR12";

        /// <summary>
        /// YCPR13.
        /// </summary>
        public const string YCPR13 = "YCPR13";

        /// <summary>
        /// YCPR14.
        /// </summary>
        public const string YCPR14 = "YCPR14";

        /// <summary>
        /// YCUSER.
        /// </summary>
        public const string YCUSER = "YCUSER";

        /// <summary>
        /// YCPR15.
        /// </summary>
        public const string YCPR15 = "YCPR15";

        /// <summary>
        /// YCPID.
        /// </summary>
        public const string YCPID = "YCPID";

        /// <summary>
        /// YCPR16.
        /// </summary>
        public const string YCPR16 = "YCPR16";

        /// <summary>
        /// YCUPMJ.
        /// </summary>
        public const string YCUPMJ = "YCUPMJ";

        /// <summary>
        /// YCPR17.
        /// </summary>
        public const string YCPR17 = "YCPR17";

        /// <summary>
        /// YCPR18.
        /// </summary>
        public const string YCPR18 = "YCPR18";

        /// <summary>
        /// YCPR19.
        /// </summary>
        public const string YCPR19 = "YCPR19";

        /// <summary>
        /// YCPR20.
        /// </summary>
        public const string YCPR20 = "YCPR20";

        /// <summary>
        /// YCODBA.
        /// </summary>
        public const string YCODBA = "YCODBA";

        /// <summary>
        /// YCSACC.
        /// </summary>
        public const string YCSACC = "YCSACC";

        /// <summary>
        /// YCCALC.
        /// </summary>
        public const string YCCALC = "YCCALC";

        /// <summary>
        /// YCPPRY.
        /// </summary>
        public const string YCPPRY = "YCPPRY";

        /// <summary>
        /// YCGVCH.
        /// </summary>
        public const string YCGVCH = "YCGVCH";

        /// <summary>
        /// YCPRTX.
        /// </summary>
        public const string YCPRTX = "YCPRTX";

        /// <summary>
        /// YCF415.
        /// </summary>
        public const string YCF415 = "YCF415";

        /// <summary>
        /// YCCLCI.
        /// </summary>
        public const string YCCLCI = "YCCLCI";

        /// <summary>
        /// YCRYTP.
        /// </summary>
        public const string YCRYTP = "YCRYTP";

        /// <summary>
        /// YCAFDT.
        /// </summary>
        public const string YCAFDT = "YCAFDT";

        /// <summary>
        /// YCSHDL.
        /// </summary>
        public const string YCSHDL = "YCSHDL";

        /// <summary>
        /// YCCHCK.
        /// </summary>
        public const string YCCHCK = "YCCHCK";

        /// <summary>
        /// YCLVPT.
        /// </summary>
        public const string YCLVPT = "YCLVPT";

        /// <summary>
        /// YCPHISH.
        /// </summary>
        public const string YCPHISH = "YCPHISH";

        /// <summary>
        /// YCLPRX.
        /// </summary>
        public const string YCLPRX = "YCLPRX";

        /// <summary>
        /// YCDEFR.
        /// </summary>
        public const string YCDEFR = "YCDEFR";

        /// <summary>
        /// YCBPPF.
        /// </summary>
        public const string YCBPPF = "YCBPPF";

        /// <summary>
        /// YCOFFE.
        /// </summary>
        public const string YCOFFE = "YCOFFE";
    }

    /// <inheritdoc />
    public override string TableName => "F069116";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("YCANN8", "YCANN8", JdeDataType.Numeric),
        new JdeField("YCEXA", "YCEXA", JdeDataType.String, 60),
        new JdeField("YCDC", "YCDC", JdeDataType.String, 80),
        new JdeField("YCPGRP", "YCPGRP", JdeDataType.String, 4),
        new JdeField("YCPAYG", "YCPAYG", JdeDataType.String, 2),
        new JdeField("YCPAYN", "YCPAYN", JdeDataType.String, 2),
        new JdeField("YCDTAB", "YCDTAB", JdeDataType.String, 10),
        new JdeField("YCSPW2", "YCSPW2", JdeDataType.String, 4),
        new JdeField("YCPB", "YCPB", JdeDataType.String, 2),
        new JdeField("YCDESQ", "YCDESQ", JdeDataType.String, 2),
        new JdeField("YCMV", "YCMV", JdeDataType.String, 2),
        new JdeField("YCDISO", "YCDISO", JdeDataType.String, 2),
        new JdeField("YCPDBA", "YCPDBA", JdeDataType.Numeric, null, true, true),
        new JdeField("YCPCK", "YCPCK", JdeDataType.String, 2),
        new JdeField("YCDEDM", "YCDEDM", JdeDataType.String, 2),
        new JdeField("YCUM", "YCUM", JdeDataType.String, 4),
        new JdeField("YCRTAM", "YCRTAM", JdeDataType.Numeric),
        new JdeField("YCPAYM", "YCPAYM", JdeDataType.Numeric),
        new JdeField("YCSHD", "YCSHD", JdeDataType.Numeric),
        new JdeField("YCCMTH", "YCCMTH", JdeDataType.String, 2),
        new JdeField("YCPPDL", "YCPPDL", JdeDataType.Numeric),
        new JdeField("YCMDL", "YCMDL", JdeDataType.Numeric),
        new JdeField("YCADL", "YCADL", JdeDataType.Numeric),
        new JdeField("YCPPPL", "YCPPPL", JdeDataType.Numeric),
        new JdeField("YCNP", "YCNP", JdeDataType.Numeric),
        new JdeField("YCAD", "YCAD", JdeDataType.Numeric),
        new JdeField("YCACO", "YCACO", JdeDataType.String, 2),
        new JdeField("YCAI", "YCAI", JdeDataType.String, 2),
        new JdeField("YCHMIN", "YCHMIN", JdeDataType.Numeric),
        new JdeField("YCHMAX", "YCHMAX", JdeDataType.Numeric),
        new JdeField("YCIIAP", "YCIIAP", JdeDataType.String, 2),
        new JdeField("YCDEP1", "YCDEP1", JdeDataType.String, 2),
        new JdeField("YCDEP2", "YCDEP2", JdeDataType.String, 2),
        new JdeField("YCDEP3", "YCDEP3", JdeDataType.String, 2),
        new JdeField("YCDEP4", "YCDEP4", JdeDataType.String, 2),
        new JdeField("YCDEP5", "YCDEP5", JdeDataType.String, 2),
        new JdeField("YCDEP6", "YCDEP6", JdeDataType.String, 2),
        new JdeField("YCTT01", "YCTT01", JdeDataType.String, 4),
        new JdeField("YCTT02", "YCTT02", JdeDataType.String, 4),
        new JdeField("YCTT03", "YCTT03", JdeDataType.String, 4),
        new JdeField("YCTT04", "YCTT04", JdeDataType.String, 4),
        new JdeField("YCTT05", "YCTT05", JdeDataType.String, 4),
        new JdeField("YCTT06", "YCTT06", JdeDataType.String, 4),
        new JdeField("YCTT07", "YCTT07", JdeDataType.String, 4),
        new JdeField("YCTT08", "YCTT08", JdeDataType.String, 4),
        new JdeField("YCTT09", "YCTT09", JdeDataType.String, 4),
        new JdeField("YCTT10", "YCTT10", JdeDataType.String, 4),
        new JdeField("YCTT11", "YCTT11", JdeDataType.String, 4),
        new JdeField("YCTT12", "YCTT12", JdeDataType.String, 4),
        new JdeField("YCTT13", "YCTT13", JdeDataType.String, 4),
        new JdeField("YCTT14", "YCTT14", JdeDataType.String, 4),
        new JdeField("YCTT15", "YCTT15", JdeDataType.String, 4),
        new JdeField("YCNMTH", "YCNMTH", JdeDataType.String, 2),
        new JdeField("YCPDED", "YCPDED", JdeDataType.Numeric),
        new JdeField("YCDPRI", "YCDPRI", JdeDataType.Numeric),
        new JdeField("YCDGRP", "YCDGRP", JdeDataType.String, 4),
        new JdeField("YCDBAL", "YCDBAL", JdeDataType.String, 2),
        new JdeField("YCARRR", "YCARRR", JdeDataType.String, 2),
        new JdeField("YCNPER", "YCNPER", JdeDataType.String, 2),
        new JdeField("YCSVCD", "YCSVCD", JdeDataType.Numeric),
        new JdeField("YCQDL", "YCQDL", JdeDataType.Numeric),
        new JdeField("YCSVH", "YCSVH", JdeDataType.String, 2),
        new JdeField("YCAAF", "YCAAF", JdeDataType.String, 2),
        new JdeField("YCPTCT", "YCPTCT", JdeDataType.String, 2),
        new JdeField("YCCPE", "YCCPE", JdeDataType.Numeric),
        new JdeField("YCEFTB", "YCEFTB", JdeDataType.Numeric),
        new JdeField("YCEFTE", "YCEFTE", JdeDataType.Numeric),
        new JdeField("YCACEQ", "YCACEQ", JdeDataType.Numeric),
        new JdeField("YCSADL", "YCSADL", JdeDataType.Numeric),
        new JdeField("YCSDED", "YCSDED", JdeDataType.Numeric),
        new JdeField("YCAMTS", "YCAMTS", JdeDataType.Numeric),
        new JdeField("YCPR01", "YCPR01", JdeDataType.String, 6),
        new JdeField("YCPR02", "YCPR02", JdeDataType.String, 6),
        new JdeField("YCPR03", "YCPR03", JdeDataType.String, 6),
        new JdeField("YCPR04", "YCPR04", JdeDataType.String, 6),
        new JdeField("YCPR05", "YCPR05", JdeDataType.String, 6),
        new JdeField("YCTASF", "YCTASF", JdeDataType.String, 2),
        new JdeField("YCTRPF", "YCTRPF", JdeDataType.String, 2),
        new JdeField("YCSALY", "YCSALY", JdeDataType.String, 2),
        new JdeField("YCCOVA", "YCCOVA", JdeDataType.Numeric),
        new JdeField("YCTRID", "YCTRID", JdeDataType.String, 4),
        new JdeField("YCTYST", "YCTYST", JdeDataType.String, 2),
        new JdeField("YCBENF", "YCBENF", JdeDataType.String, 2),
        new JdeField("YCPPPM", "YCPPPM", JdeDataType.Numeric),
        new JdeField("YCEPRI", "YCEPRI", JdeDataType.String, 2),
        new JdeField("YCPTER", "YCPTER", JdeDataType.String, 2),
        new JdeField("YCSTAB", "YCSTAB", JdeDataType.String, 10),
        new JdeField("YCCMAX", "YCCMAX", JdeDataType.Numeric),
        new JdeField("YCRTAB", "YCRTAB", JdeDataType.String, 10),
        new JdeField("YCTARA", "YCTARA", JdeDataType.String, 20),
        new JdeField("YCHMCO", "YCHMCO", JdeDataType.String, 10),
        new JdeField("YCPGM1", "YCPGM1", JdeDataType.String, 20),
        new JdeField("YCPGM2", "YCPGM2", JdeDataType.String, 20),
        new JdeField("YCTDBA", "YCTDBA", JdeDataType.String, 2),
        new JdeField("YCCMHU", "YCCMHU", JdeDataType.String, 2),
        new JdeField("YCBDT", "YCBDT", JdeDataType.String, 8),
        new JdeField("YCDBAS", "YCDBAS", JdeDataType.String, 2),
        new JdeField("YCUDBA", "YCUDBA", JdeDataType.String, 2),
        new JdeField("YCAIGR", "YCAIGR", JdeDataType.String, 2),
        new JdeField("YCPR06", "YCPR06", JdeDataType.String, 6),
        new JdeField("YCPR07", "YCPR07", JdeDataType.String, 6),
        new JdeField("YCPR08", "YCPR08", JdeDataType.String, 6),
        new JdeField("YCPR09", "YCPR09", JdeDataType.String, 6),
        new JdeField("YCPR10", "YCPR10", JdeDataType.String, 6),
        new JdeField("YCPR11", "YCPR11", JdeDataType.String, 6),
        new JdeField("YCPR12", "YCPR12", JdeDataType.String, 6),
        new JdeField("YCPR13", "YCPR13", JdeDataType.String, 6),
        new JdeField("YCPR14", "YCPR14", JdeDataType.String, 6),
        new JdeField("YCUSER", "YCUSER", JdeDataType.String, 20),
        new JdeField("YCPR15", "YCPR15", JdeDataType.String, 6),
        new JdeField("YCPID", "YCPID", JdeDataType.String, 20),
        new JdeField("YCPR16", "YCPR16", JdeDataType.String, 6),
        new JdeField("YCUPMJ", "YCUPMJ", JdeDataType.Numeric),
        new JdeField("YCPR17", "YCPR17", JdeDataType.String, 6),
        new JdeField("YCPR18", "YCPR18", JdeDataType.String, 6),
        new JdeField("YCPR19", "YCPR19", JdeDataType.String, 6),
        new JdeField("YCPR20", "YCPR20", JdeDataType.String, 6),
        new JdeField("YCODBA", "YCODBA", JdeDataType.String, 2),
        new JdeField("YCSACC", "YCSACC", JdeDataType.String, 6),
        new JdeField("YCCALC", "YCCALC", JdeDataType.String, 2),
        new JdeField("YCPPRY", "YCPPRY", JdeDataType.String, 2),
        new JdeField("YCGVCH", "YCGVCH", JdeDataType.String, 2),
        new JdeField("YCPRTX", "YCPRTX", JdeDataType.String, 6),
        new JdeField("YCF415", "YCF415", JdeDataType.String, 6),
        new JdeField("YCCLCI", "YCCLCI", JdeDataType.String, 2),
        new JdeField("YCRYTP", "YCRYTP", JdeDataType.String, 2),
        new JdeField("YCAFDT", "YCAFDT", JdeDataType.String, 8),
        new JdeField("YCSHDL", "YCSHDL", JdeDataType.String, 8),
        new JdeField("YCCHCK", "YCCHCK", JdeDataType.String, 2),
        new JdeField("YCLVPT", "YCLVPT", JdeDataType.String, 2),
        new JdeField("YCPHISH", "YCPHISH", JdeDataType.String, 2),
        new JdeField("YCLPRX", "YCLPRX", JdeDataType.String, 2),
        new JdeField("YCDEFR", "YCDEFR", JdeDataType.String, 2),
        new JdeField("YCBPPF", "YCBPPF", JdeDataType.String, 2),
        new JdeField("YCOFFE", "YCOFFE", JdeDataType.String, 2)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F069116_0", "Primary Key on YCPDBA", new[] { "YCPDBA" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F069116_10", "Index on YCSHDL", new[] { "YCSHDL" }),
        new JdeIndex("F069116_2", "Index on YCPDBA, YCDISO", new[] { "YCPDBA", "YCDISO" }),
        new JdeIndex("F069116_3", "Index on YCDC, YCDISO, YCPDBA", new[] { "YCDC", "YCDISO", "YCPDBA" }),
        new JdeIndex("F069116_4", "Index on YCDISO, YCPDBA", new[] { "YCDISO", "YCPDBA" }),
        new JdeIndex("F069116_5", "Index on YCSVH, YCPDBA", new[] { "YCSVH", "YCPDBA" }),
        new JdeIndex("F069116_6", "Index on YCTRPF, YCPDBA", new[] { "YCTRPF", "YCPDBA" }),
        new JdeIndex("F069116_7", "Index on YCDGRP", new[] { "YCDGRP" }),
        new JdeIndex("F069116_8", "Index on YCF415", new[] { "YCF415" }),
        new JdeIndex("F069116_9", "Index on YCDISO", new[] { "YCDISO" })
    };
}
