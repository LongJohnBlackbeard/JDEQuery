using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F3701 - .
/// </summary>
public class F3701 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// QAQTST.
        /// </summary>
        public const string QAQTST = "QAQTST";

        /// <summary>
        /// QAMCU.
        /// </summary>
        public const string QAMCU = "QAMCU";

        /// <summary>
        /// QASTAW.
        /// </summary>
        public const string QASTAW = "QASTAW";

        /// <summary>
        /// QAEFFT.
        /// </summary>
        public const string QAEFFT = "QAEFFT";

        /// <summary>
        /// QAQTSN.
        /// </summary>
        public const string QAQTSN = "QAQTSN";

        /// <summary>
        /// QAEFFF.
        /// </summary>
        public const string QAEFFF = "QAEFFF";

        /// <summary>
        /// QADSC1.
        /// </summary>
        public const string QADSC1 = "QADSC1";

        /// <summary>
        /// QATTTY.
        /// </summary>
        public const string QATTTY = "QATTTY";

        /// <summary>
        /// QANUMT.
        /// </summary>
        public const string QANUMT = "QANUMT";

        /// <summary>
        /// QASY.
        /// </summary>
        public const string QASY = "QASY";

        /// <summary>
        /// QART.
        /// </summary>
        public const string QART = "QART";

        /// <summary>
        /// QACDEC.
        /// </summary>
        public const string QACDEC = "QACDEC";

        /// <summary>
        /// QAQPRP.
        /// </summary>
        public const string QAQPRP = "QAQPRP";

        /// <summary>
        /// QAASTM.
        /// </summary>
        public const string QAASTM = "QAASTM";

        /// <summary>
        /// QAAMIN.
        /// </summary>
        public const string QAAMIN = "QAAMIN";

        /// <summary>
        /// QAPMIN.
        /// </summary>
        public const string QAPMIN = "QAPMIN";

        /// <summary>
        /// QAAMAX.
        /// </summary>
        public const string QAAMAX = "QAAMAX";

        /// <summary>
        /// QAPMAX.
        /// </summary>
        public const string QAPMAX = "QAPMAX";

        /// <summary>
        /// QAQTRG.
        /// </summary>
        public const string QAQTRG = "QAQTRG";

        /// <summary>
        /// QAQSSZ.
        /// </summary>
        public const string QAQSSZ = "QAQSSZ";

        /// <summary>
        /// QAQUM.
        /// </summary>
        public const string QAQUM = "QAQUM";

        /// <summary>
        /// QAQSMP.
        /// </summary>
        public const string QAQSMP = "QAQSMP";

        /// <summary>
        /// QAAVG.
        /// </summary>
        public const string QAAVG = "QAAVG";

        /// <summary>
        /// QATSDP.
        /// </summary>
        public const string QATSDP = "QATSDP";

        /// <summary>
        /// QAPTTS.
        /// </summary>
        public const string QAPTTS = "QAPTTS";

        /// <summary>
        /// QAPTTX.
        /// </summary>
        public const string QAPTTX = "QAPTTX";

        /// <summary>
        /// QAQTC1.
        /// </summary>
        public const string QAQTC1 = "QAQTC1";

        /// <summary>
        /// QAQTC2.
        /// </summary>
        public const string QAQTC2 = "QAQTC2";

        /// <summary>
        /// QAQTC3.
        /// </summary>
        public const string QAQTC3 = "QAQTC3";

        /// <summary>
        /// QAQTC4.
        /// </summary>
        public const string QAQTC4 = "QAQTC4";

        /// <summary>
        /// QAQTC5.
        /// </summary>
        public const string QAQTC5 = "QAQTC5";

        /// <summary>
        /// QASMPC.
        /// </summary>
        public const string QASMPC = "QASMPC";

        /// <summary>
        /// QAACQT.
        /// </summary>
        public const string QAACQT = "QAACQT";

        /// <summary>
        /// QAACPC.
        /// </summary>
        public const string QAACPC = "QAACPC";

        /// <summary>
        /// QAQREV.
        /// </summary>
        public const string QAQREV = "QAQREV";

        /// <summary>
        /// QATMHD.
        /// </summary>
        public const string QATMHD = "QATMHD";

        /// <summary>
        /// QARSUM.
        /// </summary>
        public const string QARSUM = "QARSUM";

        /// <summary>
        /// QANUMB.
        /// </summary>
        public const string QANUMB = "QANUMB";

        /// <summary>
        /// QAQM01.
        /// </summary>
        public const string QAQM01 = "QAQM01";

        /// <summary>
        /// QAQM02.
        /// </summary>
        public const string QAQM02 = "QAQM02";

        /// <summary>
        /// QAQM03.
        /// </summary>
        public const string QAQM03 = "QAQM03";

        /// <summary>
        /// QAQM04.
        /// </summary>
        public const string QAQM04 = "QAQM04";

        /// <summary>
        /// QAQM05.
        /// </summary>
        public const string QAQM05 = "QAQM05";

        /// <summary>
        /// QAQM06.
        /// </summary>
        public const string QAQM06 = "QAQM06";

        /// <summary>
        /// QAQM07.
        /// </summary>
        public const string QAQM07 = "QAQM07";

        /// <summary>
        /// QAQM08.
        /// </summary>
        public const string QAQM08 = "QAQM08";

        /// <summary>
        /// QAQM09.
        /// </summary>
        public const string QAQM09 = "QAQM09";

        /// <summary>
        /// QAQM10.
        /// </summary>
        public const string QAQM10 = "QAQM10";

        /// <summary>
        /// QAMMCU.
        /// </summary>
        public const string QAMMCU = "QAMMCU";

        /// <summary>
        /// QADERC.
        /// </summary>
        public const string QADERC = "QADERC";

        /// <summary>
        /// QAURCD.
        /// </summary>
        public const string QAURCD = "QAURCD";

        /// <summary>
        /// QAURDT.
        /// </summary>
        public const string QAURDT = "QAURDT";

        /// <summary>
        /// QAURAT.
        /// </summary>
        public const string QAURAT = "QAURAT";

        /// <summary>
        /// QAURRF.
        /// </summary>
        public const string QAURRF = "QAURRF";

        /// <summary>
        /// QAURAB.
        /// </summary>
        public const string QAURAB = "QAURAB";

        /// <summary>
        /// QAACTN.
        /// </summary>
        public const string QAACTN = "QAACTN";

        /// <summary>
        /// QAUKID.
        /// </summary>
        public const string QAUKID = "QAUKID";

        /// <summary>
        /// QAUSER.
        /// </summary>
        public const string QAUSER = "QAUSER";

        /// <summary>
        /// QAPID.
        /// </summary>
        public const string QAPID = "QAPID";

        /// <summary>
        /// QAUPMJ.
        /// </summary>
        public const string QAUPMJ = "QAUPMJ";

        /// <summary>
        /// QATDAY.
        /// </summary>
        public const string QATDAY = "QATDAY";

        /// <summary>
        /// QAJOBN.
        /// </summary>
        public const string QAJOBN = "QAJOBN";

        /// <summary>
        /// QATSTRSNM.
        /// </summary>
        public const string QATSTRSNM = "QATSTRSNM";

        /// <summary>
        /// QARSCONVID.
        /// </summary>
        public const string QARSCONVID = "QARSCONVID";

        /// <summary>
        /// QARSDURDY.
        /// </summary>
        public const string QARSDURDY = "QARSDURDY";

        /// <summary>
        /// QATSTDURDY.
        /// </summary>
        public const string QATSTDURDY = "QATSTDURDY";

        /// <summary>
        /// QACHGTHRES.
        /// </summary>
        public const string QACHGTHRES = "QACHGTHRES";

        /// <summary>
        /// QAQMRF1.
        /// </summary>
        public const string QAQMRF1 = "QAQMRF1";

        /// <summary>
        /// QAQMCD1.
        /// </summary>
        public const string QAQMCD1 = "QAQMCD1";

        /// <summary>
        /// QAQMAB1.
        /// </summary>
        public const string QAQMAB1 = "QAQMAB1";

        /// <summary>
        /// QAQMNUM1.
        /// </summary>
        public const string QAQMNUM1 = "QAQMNUM1";

        /// <summary>
        /// QAQMDT1.
        /// </summary>
        public const string QAQMDT1 = "QAQMDT1";

        /// <summary>
        /// QACRTLBTSK.
        /// </summary>
        public const string QACRTLBTSK = "QACRTLBTSK";

        /// <summary>
        /// QASMPMTHD.
        /// </summary>
        public const string QASMPMTHD = "QASMPMTHD";

        /// <summary>
        /// QASMPCNSL.
        /// </summary>
        public const string QASMPCNSL = "QASMPCNSL";

        /// <summary>
        /// QASMPCNTR.
        /// </summary>
        public const string QASMPCNTR = "QASMPCNTR";

        /// <summary>
        /// QASMPCLSR.
        /// </summary>
        public const string QASMPCLSR = "QASMPCLSR";

        /// <summary>
        /// QADLAB.
        /// </summary>
        public const string QADLAB = "QADLAB";

        /// <summary>
        /// QASCUKID.
        /// </summary>
        public const string QASCUKID = "QASCUKID";
    }

    /// <inheritdoc />
    public override string TableName => "F3701";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("QAQTST", "QAQTST", JdeDataType.String, 50, true, true),
        new JdeField("QAMCU", "QAMCU", JdeDataType.String, 24, true, true),
        new JdeField("QASTAW", "QASTAW", JdeDataType.String, 2, true, true),
        new JdeField("QAEFFT", "QAEFFT", JdeDataType.Numeric, null, true, true),
        new JdeField("QAQTSN", "QAQTSN", JdeDataType.Numeric, null, true, true),
        new JdeField("QAEFFF", "QAEFFF", JdeDataType.Numeric),
        new JdeField("QADSC1", "QADSC1", JdeDataType.String, 60),
        new JdeField("QATTTY", "QATTTY", JdeDataType.String, 2),
        new JdeField("QANUMT", "QANUMT", JdeDataType.String, 2),
        new JdeField("QASY", "QASY", JdeDataType.String, 8),
        new JdeField("QART", "QART", JdeDataType.String, 4),
        new JdeField("QACDEC", "QACDEC", JdeDataType.String, 2),
        new JdeField("QAQPRP", "QAQPRP", JdeDataType.String, 20),
        new JdeField("QAASTM", "QAASTM", JdeDataType.String, 60),
        new JdeField("QAAMIN", "QAAMIN", JdeDataType.String, 30),
        new JdeField("QAPMIN", "QAPMIN", JdeDataType.String, 30),
        new JdeField("QAAMAX", "QAAMAX", JdeDataType.String, 30),
        new JdeField("QAPMAX", "QAPMAX", JdeDataType.String, 30),
        new JdeField("QAQTRG", "QAQTRG", JdeDataType.String, 30),
        new JdeField("QAQSSZ", "QAQSSZ", JdeDataType.Numeric),
        new JdeField("QAQUM", "QAQUM", JdeDataType.String, 6),
        new JdeField("QAQSMP", "QAQSMP", JdeDataType.Numeric),
        new JdeField("QAAVG", "QAAVG", JdeDataType.String, 2),
        new JdeField("QATSDP", "QATSDP", JdeDataType.String, 2),
        new JdeField("QAPTTS", "QAPTTS", JdeDataType.String, 2),
        new JdeField("QAPTTX", "QAPTTX", JdeDataType.String, 2),
        new JdeField("QAQTC1", "QAQTC1", JdeDataType.String, 6),
        new JdeField("QAQTC2", "QAQTC2", JdeDataType.String, 6),
        new JdeField("QAQTC3", "QAQTC3", JdeDataType.String, 6),
        new JdeField("QAQTC4", "QAQTC4", JdeDataType.String, 6),
        new JdeField("QAQTC5", "QAQTC5", JdeDataType.String, 6),
        new JdeField("QASMPC", "QASMPC", JdeDataType.Numeric),
        new JdeField("QAACQT", "QAACQT", JdeDataType.Numeric),
        new JdeField("QAACPC", "QAACPC", JdeDataType.Numeric),
        new JdeField("QAQREV", "QAQREV", JdeDataType.String, 6),
        new JdeField("QATMHD", "QATMHD", JdeDataType.String, 60),
        new JdeField("QARSUM", "QARSUM", JdeDataType.String, 6),
        new JdeField("QANUMB", "QANUMB", JdeDataType.Numeric),
        new JdeField("QAQM01", "QAQM01", JdeDataType.String, 2),
        new JdeField("QAQM02", "QAQM02", JdeDataType.String, 2),
        new JdeField("QAQM03", "QAQM03", JdeDataType.String, 2),
        new JdeField("QAQM04", "QAQM04", JdeDataType.String, 2),
        new JdeField("QAQM05", "QAQM05", JdeDataType.String, 2),
        new JdeField("QAQM06", "QAQM06", JdeDataType.String, 2),
        new JdeField("QAQM07", "QAQM07", JdeDataType.String, 2),
        new JdeField("QAQM08", "QAQM08", JdeDataType.String, 2),
        new JdeField("QAQM09", "QAQM09", JdeDataType.String, 2),
        new JdeField("QAQM10", "QAQM10", JdeDataType.String, 2),
        new JdeField("QAMMCU", "QAMMCU", JdeDataType.String, 24),
        new JdeField("QADERC", "QADERC", JdeDataType.String, 160),
        new JdeField("QAURCD", "QAURCD", JdeDataType.String, 4),
        new JdeField("QAURDT", "QAURDT", JdeDataType.Numeric),
        new JdeField("QAURAT", "QAURAT", JdeDataType.Numeric),
        new JdeField("QAURRF", "QAURRF", JdeDataType.String, 30),
        new JdeField("QAURAB", "QAURAB", JdeDataType.Numeric),
        new JdeField("QAACTN", "QAACTN", JdeDataType.String, 2),
        new JdeField("QAUKID", "QAUKID", JdeDataType.Numeric),
        new JdeField("QAUSER", "QAUSER", JdeDataType.String, 20),
        new JdeField("QAPID", "QAPID", JdeDataType.String, 20),
        new JdeField("QAUPMJ", "QAUPMJ", JdeDataType.Numeric),
        new JdeField("QATDAY", "QATDAY", JdeDataType.Numeric),
        new JdeField("QAJOBN", "QAJOBN", JdeDataType.String, 20),
        new JdeField("QATSTRSNM", "QATSTRSNM", JdeDataType.String, 60),
        new JdeField("QARSCONVID", "QARSCONVID", JdeDataType.String, 60),
        new JdeField("QARSDURDY", "QARSDURDY", JdeDataType.Numeric),
        new JdeField("QATSTDURDY", "QATSTDURDY", JdeDataType.Numeric),
        new JdeField("QACHGTHRES", "QACHGTHRES", JdeDataType.Numeric),
        new JdeField("QAQMRF1", "QAQMRF1", JdeDataType.String, 60),
        new JdeField("QAQMCD1", "QAQMCD1", JdeDataType.String, 6),
        new JdeField("QAQMAB1", "QAQMAB1", JdeDataType.Numeric),
        new JdeField("QAQMNUM1", "QAQMNUM1", JdeDataType.Numeric),
        new JdeField("QAQMDT1", "QAQMDT1", JdeDataType.Numeric),
        new JdeField("QACRTLBTSK", "QACRTLBTSK", JdeDataType.String, 2),
        new JdeField("QASMPMTHD", "QASMPMTHD", JdeDataType.String, 20),
        new JdeField("QASMPCNSL", "QASMPCNSL", JdeDataType.String, 4),
        new JdeField("QASMPCNTR", "QASMPCNTR", JdeDataType.String, 20),
        new JdeField("QASMPCLSR", "QASMPCLSR", JdeDataType.String, 20),
        new JdeField("QADLAB", "QADLAB", JdeDataType.Numeric),
        new JdeField("QASCUKID", "QASCUKID", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F3701_0", "Primary Key on QAQTST, QAMCU, QASTAW, QAEFFT, QAQTSN", new[] { "QAQTST", "QAMCU", "QASTAW", "QAEFFT", "QAQTSN" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F3701_2", "Index on QAUKID", new[] { "QAUKID" }),
        new JdeIndex("F3701_3", "Index on QASMPCNTR", new[] { "QASMPCNTR" })
    };
}
