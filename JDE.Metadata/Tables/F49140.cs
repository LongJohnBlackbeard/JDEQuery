using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F49140 - .
/// </summary>
public class F49140 : JdeTable
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
        /// BWSHPN.
        /// </summary>
        public const string BWSHPN = "BWSHPN";

        /// <summary>
        /// BWRSSN.
        /// </summary>
        public const string BWRSSN = "BWRSSN";

        /// <summary>
        /// BWOSEQ.
        /// </summary>
        public const string BWOSEQ = "BWOSEQ";

        /// <summary>
        /// BWORGN.
        /// </summary>
        public const string BWORGN = "BWORGN";

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
        /// BWANCC.
        /// </summary>
        public const string BWANCC = "BWANCC";

        /// <summary>
        /// BWSAMLNM.
        /// </summary>
        public const string BWSAMLNM = "BWSAMLNM";

        /// <summary>
        /// BWSHL1.
        /// </summary>
        public const string BWSHL1 = "BWSHL1";

        /// <summary>
        /// BWSHL2.
        /// </summary>
        public const string BWSHL2 = "BWSHL2";

        /// <summary>
        /// BWSHL3.
        /// </summary>
        public const string BWSHL3 = "BWSHL3";

        /// <summary>
        /// BWSHL4.
        /// </summary>
        public const string BWSHL4 = "BWSHL4";

        /// <summary>
        /// BWSHL5.
        /// </summary>
        public const string BWSHL5 = "BWSHL5";

        /// <summary>
        /// BWSHL6.
        /// </summary>
        public const string BWSHL6 = "BWSHL6";

        /// <summary>
        /// BWADD0.
        /// </summary>
        public const string BWADD0 = "BWADD0";

        /// <summary>
        /// BWGWEI.
        /// </summary>
        public const string BWGWEI = "BWGWEI";

        /// <summary>
        /// BWWTEM.
        /// </summary>
        public const string BWWTEM = "BWWTEM";

        /// <summary>
        /// BWWTUM.
        /// </summary>
        public const string BWWTUM = "BWWTUM";

        /// <summary>
        /// BWEQTY.
        /// </summary>
        public const string BWEQTY = "BWEQTY";

        /// <summary>
        /// BWCNID.
        /// </summary>
        public const string BWCNID = "BWCNID";

        /// <summary>
        /// BWLGTS.
        /// </summary>
        public const string BWLGTS = "BWLGTS";

        /// <summary>
        /// BWWTHS.
        /// </summary>
        public const string BWWTHS = "BWWTHS";

        /// <summary>
        /// BWHGTS.
        /// </summary>
        public const string BWHGTS = "BWHGTS";

        /// <summary>
        /// BWGTHS.
        /// </summary>
        public const string BWGTHS = "BWGTHS";

        /// <summary>
        /// BWLUOM.
        /// </summary>
        public const string BWLUOM = "BWLUOM";

        /// <summary>
        /// BWVCUD.
        /// </summary>
        public const string BWVCUD = "BWVCUD";

        /// <summary>
        /// BWCVUM.
        /// </summary>
        public const string BWCVUM = "BWCVUM";

        /// <summary>
        /// BWPLT.
        /// </summary>
        public const string BWPLT = "BWPLT";

        /// <summary>
        /// BWREFQ.
        /// </summary>
        public const string BWREFQ = "BWREFQ";

        /// <summary>
        /// BWREFN.
        /// </summary>
        public const string BWREFN = "BWREFN";

        /// <summary>
        /// BWMCU.
        /// </summary>
        public const string BWMCU = "BWMCU";

        /// <summary>
        /// BWDTDO.
        /// </summary>
        public const string BWDTDO = "BWDTDO";

        /// <summary>
        /// BWREFN1.
        /// </summary>
        public const string BWREFN1 = "BWREFN1";

        /// <summary>
        /// BWSDPC.
        /// </summary>
        public const string BWSDPC = "BWSDPC";

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
    }

    /// <inheritdoc />
    public override string TableName => "F49140";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("BWBN01", "BWBN01", JdeDataType.Numeric, null, true, true),
        new JdeField("BWMCUZ", "BWMCUZ", JdeDataType.String, 24, true, true),
        new JdeField("BWDCCD", "BWDCCD", JdeDataType.String, 8, true, true),
        new JdeField("BWCTID", "BWCTID", JdeDataType.String, 30, true, true),
        new JdeField("BWSHPN", "BWSHPN", JdeDataType.Numeric, null, true, true),
        new JdeField("BWRSSN", "BWRSSN", JdeDataType.Numeric, null, true, true),
        new JdeField("BWOSEQ", "BWOSEQ", JdeDataType.Numeric, null, true, true),
        new JdeField("BWORGN", "BWORGN", JdeDataType.Numeric),
        new JdeField("BWALPH", "BWALPH", JdeDataType.String, 80),
        new JdeField("BWADD1", "BWADD1", JdeDataType.String, 80),
        new JdeField("BWADD2", "BWADD2", JdeDataType.String, 80),
        new JdeField("BWADD3", "BWADD3", JdeDataType.String, 80),
        new JdeField("BWADD4", "BWADD4", JdeDataType.String, 80),
        new JdeField("BWADD5", "BWADD5", JdeDataType.String, 80),
        new JdeField("BWADD6", "BWADD6", JdeDataType.String, 80),
        new JdeField("BWADD7", "BWADD7", JdeDataType.String, 80),
        new JdeField("BWANCC", "BWANCC", JdeDataType.Numeric),
        new JdeField("BWSAMLNM", "BWSAMLNM", JdeDataType.String, 80),
        new JdeField("BWSHL1", "BWSHL1", JdeDataType.String, 80),
        new JdeField("BWSHL2", "BWSHL2", JdeDataType.String, 80),
        new JdeField("BWSHL3", "BWSHL3", JdeDataType.String, 80),
        new JdeField("BWSHL4", "BWSHL4", JdeDataType.String, 80),
        new JdeField("BWSHL5", "BWSHL5", JdeDataType.String, 80),
        new JdeField("BWSHL6", "BWSHL6", JdeDataType.String, 80),
        new JdeField("BWADD0", "BWADD0", JdeDataType.String, 80),
        new JdeField("BWGWEI", "BWGWEI", JdeDataType.Numeric),
        new JdeField("BWWTEM", "BWWTEM", JdeDataType.Numeric),
        new JdeField("BWWTUM", "BWWTUM", JdeDataType.String, 4),
        new JdeField("BWEQTY", "BWEQTY", JdeDataType.String, 10),
        new JdeField("BWCNID", "BWCNID", JdeDataType.String, 40),
        new JdeField("BWLGTS", "BWLGTS", JdeDataType.Numeric),
        new JdeField("BWWTHS", "BWWTHS", JdeDataType.Numeric),
        new JdeField("BWHGTS", "BWHGTS", JdeDataType.Numeric),
        new JdeField("BWGTHS", "BWGTHS", JdeDataType.Numeric),
        new JdeField("BWLUOM", "BWLUOM", JdeDataType.String, 4),
        new JdeField("BWVCUD", "BWVCUD", JdeDataType.Numeric),
        new JdeField("BWCVUM", "BWCVUM", JdeDataType.String, 4),
        new JdeField("BWPLT", "BWPLT", JdeDataType.String, 36),
        new JdeField("BWREFQ", "BWREFQ", JdeDataType.String, 4),
        new JdeField("BWREFN", "BWREFN", JdeDataType.String, 60),
        new JdeField("BWMCU", "BWMCU", JdeDataType.String, 24),
        new JdeField("BWDTDO", "BWDTDO", JdeDataType.Numeric),
        new JdeField("BWREFN1", "BWREFN1", JdeDataType.String, 60),
        new JdeField("BWSDPC", "BWSDPC", JdeDataType.String, 2),
        new JdeField("BWURCD", "BWURCD", JdeDataType.String, 4),
        new JdeField("BWURDT", "BWURDT", JdeDataType.Numeric),
        new JdeField("BWURAT", "BWURAT", JdeDataType.Numeric),
        new JdeField("BWURAB", "BWURAB", JdeDataType.Numeric),
        new JdeField("BWURRF", "BWURRF", JdeDataType.String, 30)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F49140_0", "Primary Key on BWBN01, BWMCUZ, BWDCCD, BWCTID, BWSHPN, BWRSSN, BWOSEQ", new[] { "BWBN01", "BWMCUZ", "BWDCCD", "BWCTID", "BWSHPN", "BWRSSN", "BWOSEQ" }, isUnique: true, isPrimaryKey: true)
    };
}
