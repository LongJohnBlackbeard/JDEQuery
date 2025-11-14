using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F49130 - .
/// </summary>
public class F49130 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// BWBN01.
        /// </summary>
        public const string BWBN01 = "BWBN01";

        /// <summary>
        /// BWMCUZ.
        /// </summary>
        public const string BWMCUZ = "BWMCUZ";

        /// <summary>
        /// BWDCCD.
        /// </summary>
        public const string BWDCCD = "BWDCCD";

        /// <summary>
        /// BWCTID.
        /// </summary>
        public const string BWCTID = "BWCTID";

        /// <summary>
        /// BWJOBS.
        /// </summary>
        public const string BWJOBS = "BWJOBS";

        /// <summary>
        /// BWVMCU.
        /// </summary>
        public const string BWVMCU = "BWVMCU";

        /// <summary>
        /// BWLDNM.
        /// </summary>
        public const string BWLDNM = "BWLDNM";

        /// <summary>
        /// BWSHPN.
        /// </summary>
        public const string BWSHPN = "BWSHPN";

        /// <summary>
        /// BWRSSN.
        /// </summary>
        public const string BWRSSN = "BWRSSN";

        /// <summary>
        /// BWSEQN.
        /// </summary>
        public const string BWSEQN = "BWSEQN";

        /// <summary>
        /// BWSDPC.
        /// </summary>
        public const string BWSDPC = "BWSDPC";

        /// <summary>
        /// BWORGN.
        /// </summary>
        public const string BWORGN = "BWORGN";

        /// <summary>
        /// BWANCC.
        /// </summary>
        public const string BWANCC = "BWANCC";

        /// <summary>
        /// BWCARS.
        /// </summary>
        public const string BWCARS = "BWCARS";

        /// <summary>
        /// BWMOT.
        /// </summary>
        public const string BWMOT = "BWMOT";

        /// <summary>
        /// BWFRTH.
        /// </summary>
        public const string BWFRTH = "BWFRTH";

        /// <summary>
        /// BWALPH.
        /// </summary>
        public const string BWALPH = "BWALPH";

        /// <summary>
        /// BWADD1.
        /// </summary>
        public const string BWADD1 = "BWADD1";

        /// <summary>
        /// BWADD2.
        /// </summary>
        public const string BWADD2 = "BWADD2";

        /// <summary>
        /// BWADD3.
        /// </summary>
        public const string BWADD3 = "BWADD3";

        /// <summary>
        /// BWADD4.
        /// </summary>
        public const string BWADD4 = "BWADD4";

        /// <summary>
        /// BWADD5.
        /// </summary>
        public const string BWADD5 = "BWADD5";

        /// <summary>
        /// BWADD6.
        /// </summary>
        public const string BWADD6 = "BWADD6";

        /// <summary>
        /// BWADD7.
        /// </summary>
        public const string BWADD7 = "BWADD7";

        /// <summary>
        /// BWNPCS.
        /// </summary>
        public const string BWNPCS = "BWNPCS";

        /// <summary>
        /// BWNCTR.
        /// </summary>
        public const string BWNCTR = "BWNCTR";

        /// <summary>
        /// BWWGTS.
        /// </summary>
        public const string BWWGTS = "BWWGTS";

        /// <summary>
        /// BWWTUM.
        /// </summary>
        public const string BWWTUM = "BWWTUM";

        /// <summary>
        /// BWDOC.
        /// </summary>
        public const string BWDOC = "BWDOC";

        /// <summary>
        /// BWDCT.
        /// </summary>
        public const string BWDCT = "BWDCT";

        /// <summary>
        /// BWKCO.
        /// </summary>
        public const string BWKCO = "BWKCO";

        /// <summary>
        /// BWDCNS.
        /// </summary>
        public const string BWDCNS = "BWDCNS";

        /// <summary>
        /// BWCO.
        /// </summary>
        public const string BWCO = "BWCO";

        /// <summary>
        /// BWEMCU.
        /// </summary>
        public const string BWEMCU = "BWEMCU";

        /// <summary>
        /// BWMCU.
        /// </summary>
        public const string BWMCU = "BWMCU";

        /// <summary>
        /// BWDTDO.
        /// </summary>
        public const string BWDTDO = "BWDTDO";

        /// <summary>
        /// BWREFQ.
        /// </summary>
        public const string BWREFQ = "BWREFQ";

        /// <summary>
        /// BWREFN.
        /// </summary>
        public const string BWREFN = "BWREFN";

        /// <summary>
        /// BWDLNO.
        /// </summary>
        public const string BWDLNO = "BWDLNO";

        /// <summary>
        /// BWURCD.
        /// </summary>
        public const string BWURCD = "BWURCD";

        /// <summary>
        /// BWURDT.
        /// </summary>
        public const string BWURDT = "BWURDT";

        /// <summary>
        /// BWURAT.
        /// </summary>
        public const string BWURAT = "BWURAT";

        /// <summary>
        /// BWURAB.
        /// </summary>
        public const string BWURAB = "BWURAB";

        /// <summary>
        /// BWURRF.
        /// </summary>
        public const string BWURRF = "BWURRF";

        /// <summary>
        /// BWGCARS.
        /// </summary>
        public const string BWGCARS = "BWGCARS";

        /// <summary>
        /// BWGSHAN.
        /// </summary>
        public const string BWGSHAN = "BWGSHAN";
    }

    /// <inheritdoc />
    public override string TableName => "F49130";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("BWBN01", "BWBN01", JdeDataType.Numeric, null, true, true),
        new JdeField("BWMCUZ", "BWMCUZ", JdeDataType.String, 24, true, true),
        new JdeField("BWDCCD", "BWDCCD", JdeDataType.String, 8, true, true),
        new JdeField("BWCTID", "BWCTID", JdeDataType.String, 30, true, true),
        new JdeField("BWJOBS", "BWJOBS", JdeDataType.Numeric, null, true, true),
        new JdeField("BWVMCU", "BWVMCU", JdeDataType.String, 24, true, true),
        new JdeField("BWLDNM", "BWLDNM", JdeDataType.Numeric, null, true, true),
        new JdeField("BWSHPN", "BWSHPN", JdeDataType.Numeric, null, true, true),
        new JdeField("BWRSSN", "BWRSSN", JdeDataType.Numeric, null, true, true),
        new JdeField("BWSEQN", "BWSEQN", JdeDataType.Numeric),
        new JdeField("BWSDPC", "BWSDPC", JdeDataType.String, 2),
        new JdeField("BWORGN", "BWORGN", JdeDataType.Numeric),
        new JdeField("BWANCC", "BWANCC", JdeDataType.Numeric),
        new JdeField("BWCARS", "BWCARS", JdeDataType.Numeric),
        new JdeField("BWMOT", "BWMOT", JdeDataType.String, 6),
        new JdeField("BWFRTH", "BWFRTH", JdeDataType.String, 6),
        new JdeField("BWALPH", "BWALPH", JdeDataType.String, 80),
        new JdeField("BWADD1", "BWADD1", JdeDataType.String, 80),
        new JdeField("BWADD2", "BWADD2", JdeDataType.String, 80),
        new JdeField("BWADD3", "BWADD3", JdeDataType.String, 80),
        new JdeField("BWADD4", "BWADD4", JdeDataType.String, 80),
        new JdeField("BWADD5", "BWADD5", JdeDataType.String, 80),
        new JdeField("BWADD6", "BWADD6", JdeDataType.String, 80),
        new JdeField("BWADD7", "BWADD7", JdeDataType.String, 80),
        new JdeField("BWNPCS", "BWNPCS", JdeDataType.Numeric),
        new JdeField("BWNCTR", "BWNCTR", JdeDataType.Numeric),
        new JdeField("BWWGTS", "BWWGTS", JdeDataType.Numeric),
        new JdeField("BWWTUM", "BWWTUM", JdeDataType.String, 4),
        new JdeField("BWDOC", "BWDOC", JdeDataType.Numeric),
        new JdeField("BWDCT", "BWDCT", JdeDataType.String, 4),
        new JdeField("BWKCO", "BWKCO", JdeDataType.String, 10),
        new JdeField("BWDCNS", "BWDCNS", JdeDataType.String, 2),
        new JdeField("BWCO", "BWCO", JdeDataType.String, 10),
        new JdeField("BWEMCU", "BWEMCU", JdeDataType.String, 24),
        new JdeField("BWMCU", "BWMCU", JdeDataType.String, 24),
        new JdeField("BWDTDO", "BWDTDO", JdeDataType.Numeric),
        new JdeField("BWREFQ", "BWREFQ", JdeDataType.String, 4),
        new JdeField("BWREFN", "BWREFN", JdeDataType.String, 60),
        new JdeField("BWDLNO", "BWDLNO", JdeDataType.Numeric),
        new JdeField("BWURCD", "BWURCD", JdeDataType.String, 4),
        new JdeField("BWURDT", "BWURDT", JdeDataType.Numeric),
        new JdeField("BWURAT", "BWURAT", JdeDataType.Numeric),
        new JdeField("BWURAB", "BWURAB", JdeDataType.Numeric),
        new JdeField("BWURRF", "BWURRF", JdeDataType.String, 30),
        new JdeField("BWGCARS", "BWGCARS", JdeDataType.Numeric),
        new JdeField("BWGSHAN", "BWGSHAN", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F49130_0", "Primary Key on BWBN01, BWMCUZ, BWDCCD, BWCTID, BWJOBS, BWVMCU, BWLDNM, BWSHPN, BWRSSN", new[] { "BWBN01", "BWMCUZ", "BWDCCD", "BWCTID", "BWJOBS", "BWVMCU", "BWLDNM", "BWSHPN", "BWRSSN" }, isUnique: true, isPrimaryKey: true)
    };
}
