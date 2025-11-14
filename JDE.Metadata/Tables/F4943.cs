using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F4943 - .
/// </summary>
public class F4943 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// SPSHPN.
        /// </summary>
        public const string SPSHPN = "SPSHPN";

        /// <summary>
        /// SPRSSN.
        /// </summary>
        public const string SPRSSN = "SPRSSN";

        /// <summary>
        /// SPOSEQ.
        /// </summary>
        public const string SPOSEQ = "SPOSEQ";

        /// <summary>
        /// SPEQTY.
        /// </summary>
        public const string SPEQTY = "SPEQTY";

        /// <summary>
        /// SPLGTS.
        /// </summary>
        public const string SPLGTS = "SPLGTS";

        /// <summary>
        /// SPWTHS.
        /// </summary>
        public const string SPWTHS = "SPWTHS";

        /// <summary>
        /// SPHGTS.
        /// </summary>
        public const string SPHGTS = "SPHGTS";

        /// <summary>
        /// SPGTHS.
        /// </summary>
        public const string SPGTHS = "SPGTHS";

        /// <summary>
        /// SPLUOM.
        /// </summary>
        public const string SPLUOM = "SPLUOM";

        /// <summary>
        /// SPGWEI.
        /// </summary>
        public const string SPGWEI = "SPGWEI";

        /// <summary>
        /// SPWTEM.
        /// </summary>
        public const string SPWTEM = "SPWTEM";

        /// <summary>
        /// SPWTUM.
        /// </summary>
        public const string SPWTUM = "SPWTUM";

        /// <summary>
        /// SPVCUD.
        /// </summary>
        public const string SPVCUD = "SPVCUD";

        /// <summary>
        /// SPCVUM.
        /// </summary>
        public const string SPCVUM = "SPCVUM";

        /// <summary>
        /// SPCNID.
        /// </summary>
        public const string SPCNID = "SPCNID";

        /// <summary>
        /// SPPLT.
        /// </summary>
        public const string SPPLT = "SPPLT";

        /// <summary>
        /// SPREFQ.
        /// </summary>
        public const string SPREFQ = "SPREFQ";

        /// <summary>
        /// SPREFN.
        /// </summary>
        public const string SPREFN = "SPREFN";

        /// <summary>
        /// SPURCD.
        /// </summary>
        public const string SPURCD = "SPURCD";

        /// <summary>
        /// SPURDT.
        /// </summary>
        public const string SPURDT = "SPURDT";

        /// <summary>
        /// SPURAT.
        /// </summary>
        public const string SPURAT = "SPURAT";

        /// <summary>
        /// SPURAB.
        /// </summary>
        public const string SPURAB = "SPURAB";

        /// <summary>
        /// SPURRF.
        /// </summary>
        public const string SPURRF = "SPURRF";

        /// <summary>
        /// SPUSER.
        /// </summary>
        public const string SPUSER = "SPUSER";

        /// <summary>
        /// SPPID.
        /// </summary>
        public const string SPPID = "SPPID";

        /// <summary>
        /// SPJOBN.
        /// </summary>
        public const string SPJOBN = "SPJOBN";

        /// <summary>
        /// SPUPMJ.
        /// </summary>
        public const string SPUPMJ = "SPUPMJ";

        /// <summary>
        /// SPTDAY.
        /// </summary>
        public const string SPTDAY = "SPTDAY";
    }

    /// <inheritdoc />
    public override string TableName => "F4943";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("SPSHPN", "SPSHPN", JdeDataType.Numeric, null, true, true),
        new JdeField("SPRSSN", "SPRSSN", JdeDataType.Numeric, null, true, true),
        new JdeField("SPOSEQ", "SPOSEQ", JdeDataType.Numeric, null, true, true),
        new JdeField("SPEQTY", "SPEQTY", JdeDataType.String, 10),
        new JdeField("SPLGTS", "SPLGTS", JdeDataType.Numeric),
        new JdeField("SPWTHS", "SPWTHS", JdeDataType.Numeric),
        new JdeField("SPHGTS", "SPHGTS", JdeDataType.Numeric),
        new JdeField("SPGTHS", "SPGTHS", JdeDataType.Numeric),
        new JdeField("SPLUOM", "SPLUOM", JdeDataType.String, 4),
        new JdeField("SPGWEI", "SPGWEI", JdeDataType.Numeric),
        new JdeField("SPWTEM", "SPWTEM", JdeDataType.Numeric),
        new JdeField("SPWTUM", "SPWTUM", JdeDataType.String, 4),
        new JdeField("SPVCUD", "SPVCUD", JdeDataType.Numeric),
        new JdeField("SPCVUM", "SPCVUM", JdeDataType.String, 4),
        new JdeField("SPCNID", "SPCNID", JdeDataType.String, 40),
        new JdeField("SPPLT", "SPPLT", JdeDataType.String, 36, true, true),
        new JdeField("SPREFQ", "SPREFQ", JdeDataType.String, 4),
        new JdeField("SPREFN", "SPREFN", JdeDataType.String, 60),
        new JdeField("SPURCD", "SPURCD", JdeDataType.String, 4),
        new JdeField("SPURDT", "SPURDT", JdeDataType.Numeric),
        new JdeField("SPURAT", "SPURAT", JdeDataType.Numeric),
        new JdeField("SPURAB", "SPURAB", JdeDataType.Numeric),
        new JdeField("SPURRF", "SPURRF", JdeDataType.String, 30),
        new JdeField("SPUSER", "SPUSER", JdeDataType.String, 20),
        new JdeField("SPPID", "SPPID", JdeDataType.String, 20),
        new JdeField("SPJOBN", "SPJOBN", JdeDataType.String, 20),
        new JdeField("SPUPMJ", "SPUPMJ", JdeDataType.Numeric),
        new JdeField("SPTDAY", "SPTDAY", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F4943_0", "Primary Key on SPSHPN, SPRSSN, SPOSEQ, SPPLT", new[] { "SPSHPN", "SPRSSN", "SPOSEQ", "SPPLT" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F4943_2", "Index on SPSHPN, SPRSSN, SPPLT", new[] { "SPSHPN", "SPRSSN", "SPPLT" }),
        new JdeIndex("F4943_3", "Index on SPSHPN, SPRSSN, SPCNID", new[] { "SPSHPN", "SPRSSN", "SPCNID" }),
        new JdeIndex("F4943_4", "Index on SYS_NC00029$, SYS_NC00030$, SYS_NC00031$", new[] { "SYS_NC00029$", "SYS_NC00030$", "SYS_NC00031$" }),
        new JdeIndex("F4943_5", "Index on SPREFN, SPREFQ", new[] { "SPREFN", "SPREFQ" }),
        new JdeIndex("F4943_6", "Index on SPPLT", new[] { "SPPLT" })
    };
}
