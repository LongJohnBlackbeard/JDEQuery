using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F4942Z1 - .
/// </summary>
public class F4942Z1 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// SYEDUS.
        /// </summary>
        public const string SYEDUS = "SYEDUS";

        /// <summary>
        /// SYEDBT.
        /// </summary>
        public const string SYEDBT = "SYEDBT";

        /// <summary>
        /// SYEDTN.
        /// </summary>
        public const string SYEDTN = "SYEDTN";

        /// <summary>
        /// SYEDLN.
        /// </summary>
        public const string SYEDLN = "SYEDLN";

        /// <summary>
        /// SYEDCT.
        /// </summary>
        public const string SYEDCT = "SYEDCT";

        /// <summary>
        /// SYTYTN.
        /// </summary>
        public const string SYTYTN = "SYTYTN";

        /// <summary>
        /// SYEDFT.
        /// </summary>
        public const string SYEDFT = "SYEDFT";

        /// <summary>
        /// SYEDDT.
        /// </summary>
        public const string SYEDDT = "SYEDDT";

        /// <summary>
        /// SYDRIN.
        /// </summary>
        public const string SYDRIN = "SYDRIN";

        /// <summary>
        /// SYEDDL.
        /// </summary>
        public const string SYEDDL = "SYEDDL";

        /// <summary>
        /// SYEDSP.
        /// </summary>
        public const string SYEDSP = "SYEDSP";

        /// <summary>
        /// SYPNID.
        /// </summary>
        public const string SYPNID = "SYPNID";

        /// <summary>
        /// SYTNAC.
        /// </summary>
        public const string SYTNAC = "SYTNAC";

        /// <summary>
        /// SYDOCO.
        /// </summary>
        public const string SYDOCO = "SYDOCO";

        /// <summary>
        /// SYDCTO.
        /// </summary>
        public const string SYDCTO = "SYDCTO";

        /// <summary>
        /// SYKCOO.
        /// </summary>
        public const string SYKCOO = "SYKCOO";

        /// <summary>
        /// SYLNID.
        /// </summary>
        public const string SYLNID = "SYLNID";

        /// <summary>
        /// SYLNTY.
        /// </summary>
        public const string SYLNTY = "SYLNTY";

        /// <summary>
        /// SYMCU.
        /// </summary>
        public const string SYMCU = "SYMCU";

        /// <summary>
        /// SYSHAN.
        /// </summary>
        public const string SYSHAN = "SYSHAN";

        /// <summary>
        /// SYAN8.
        /// </summary>
        public const string SYAN8 = "SYAN8";

        /// <summary>
        /// SYPPDJ.
        /// </summary>
        public const string SYPPDJ = "SYPPDJ";

        /// <summary>
        /// SYRSDJ.
        /// </summary>
        public const string SYRSDJ = "SYRSDJ";

        /// <summary>
        /// SYDRQJ.
        /// </summary>
        public const string SYDRQJ = "SYDRQJ";

        /// <summary>
        /// SYSO07.
        /// </summary>
        public const string SYSO07 = "SYSO07";

        /// <summary>
        /// SYITM.
        /// </summary>
        public const string SYITM = "SYITM";

        /// <summary>
        /// SYSOQS.
        /// </summary>
        public const string SYSOQS = "SYSOQS";

        /// <summary>
        /// SYUOM.
        /// </summary>
        public const string SYUOM = "SYUOM";

        /// <summary>
        /// SYITWT.
        /// </summary>
        public const string SYITWT = "SYITWT";

        /// <summary>
        /// SYWTUM.
        /// </summary>
        public const string SYWTUM = "SYWTUM";

        /// <summary>
        /// SYITVL.
        /// </summary>
        public const string SYITVL = "SYITVL";

        /// <summary>
        /// SYVLUM.
        /// </summary>
        public const string SYVLUM = "SYVLUM";

        /// <summary>
        /// SYAEXP.
        /// </summary>
        public const string SYAEXP = "SYAEXP";

        /// <summary>
        /// SYFEA.
        /// </summary>
        public const string SYFEA = "SYFEA";

        /// <summary>
        /// SYCRCD.
        /// </summary>
        public const string SYCRCD = "SYCRCD";

        /// <summary>
        /// SYFRTH.
        /// </summary>
        public const string SYFRTH = "SYFRTH";

        /// <summary>
        /// SYPRP1.
        /// </summary>
        public const string SYPRP1 = "SYPRP1";

        /// <summary>
        /// SYMOT.
        /// </summary>
        public const string SYMOT = "SYMOT";

        /// <summary>
        /// SYCARS.
        /// </summary>
        public const string SYCARS = "SYCARS";

        /// <summary>
        /// SYECST.
        /// </summary>
        public const string SYECST = "SYECST";

        /// <summary>
        /// SYCRDC.
        /// </summary>
        public const string SYCRDC = "SYCRDC";

        /// <summary>
        /// SYURCD.
        /// </summary>
        public const string SYURCD = "SYURCD";

        /// <summary>
        /// SYURDT.
        /// </summary>
        public const string SYURDT = "SYURDT";

        /// <summary>
        /// SYURAT.
        /// </summary>
        public const string SYURAT = "SYURAT";

        /// <summary>
        /// SYURAB.
        /// </summary>
        public const string SYURAB = "SYURAB";

        /// <summary>
        /// SYURRF.
        /// </summary>
        public const string SYURRF = "SYURRF";

        /// <summary>
        /// SYTORG.
        /// </summary>
        public const string SYTORG = "SYTORG";

        /// <summary>
        /// SYUSER.
        /// </summary>
        public const string SYUSER = "SYUSER";

        /// <summary>
        /// SYPID.
        /// </summary>
        public const string SYPID = "SYPID";

        /// <summary>
        /// SYJOBN.
        /// </summary>
        public const string SYJOBN = "SYJOBN";

        /// <summary>
        /// SYUPMJ.
        /// </summary>
        public const string SYUPMJ = "SYUPMJ";

        /// <summary>
        /// SYTDAY.
        /// </summary>
        public const string SYTDAY = "SYTDAY";
    }

    /// <inheritdoc />
    public override string TableName => "F4942Z1";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("SYEDUS", "SYEDUS", JdeDataType.String, 20, true, true),
        new JdeField("SYEDBT", "SYEDBT", JdeDataType.String, 30, true, true),
        new JdeField("SYEDTN", "SYEDTN", JdeDataType.String, 44, true, true),
        new JdeField("SYEDLN", "SYEDLN", JdeDataType.Numeric, null, true, true),
        new JdeField("SYEDCT", "SYEDCT", JdeDataType.String, 4),
        new JdeField("SYTYTN", "SYTYTN", JdeDataType.String, 16),
        new JdeField("SYEDFT", "SYEDFT", JdeDataType.String, 20),
        new JdeField("SYEDDT", "SYEDDT", JdeDataType.Numeric),
        new JdeField("SYDRIN", "SYDRIN", JdeDataType.String, 2),
        new JdeField("SYEDDL", "SYEDDL", JdeDataType.Numeric),
        new JdeField("SYEDSP", "SYEDSP", JdeDataType.String, 2),
        new JdeField("SYPNID", "SYPNID", JdeDataType.String, 30),
        new JdeField("SYTNAC", "SYTNAC", JdeDataType.String, 4),
        new JdeField("SYDOCO", "SYDOCO", JdeDataType.Numeric),
        new JdeField("SYDCTO", "SYDCTO", JdeDataType.String, 4),
        new JdeField("SYKCOO", "SYKCOO", JdeDataType.String, 10),
        new JdeField("SYLNID", "SYLNID", JdeDataType.Numeric),
        new JdeField("SYLNTY", "SYLNTY", JdeDataType.String, 4),
        new JdeField("SYMCU", "SYMCU", JdeDataType.String, 24),
        new JdeField("SYSHAN", "SYSHAN", JdeDataType.Numeric),
        new JdeField("SYAN8", "SYAN8", JdeDataType.Numeric),
        new JdeField("SYPPDJ", "SYPPDJ", JdeDataType.Numeric),
        new JdeField("SYRSDJ", "SYRSDJ", JdeDataType.Numeric),
        new JdeField("SYDRQJ", "SYDRQJ", JdeDataType.Numeric),
        new JdeField("SYSO07", "SYSO07", JdeDataType.String, 2),
        new JdeField("SYITM", "SYITM", JdeDataType.Numeric),
        new JdeField("SYSOQS", "SYSOQS", JdeDataType.Numeric),
        new JdeField("SYUOM", "SYUOM", JdeDataType.String, 4),
        new JdeField("SYITWT", "SYITWT", JdeDataType.Numeric),
        new JdeField("SYWTUM", "SYWTUM", JdeDataType.String, 4),
        new JdeField("SYITVL", "SYITVL", JdeDataType.Numeric),
        new JdeField("SYVLUM", "SYVLUM", JdeDataType.String, 4),
        new JdeField("SYAEXP", "SYAEXP", JdeDataType.Numeric),
        new JdeField("SYFEA", "SYFEA", JdeDataType.Numeric),
        new JdeField("SYCRCD", "SYCRCD", JdeDataType.String, 6),
        new JdeField("SYFRTH", "SYFRTH", JdeDataType.String, 6),
        new JdeField("SYPRP1", "SYPRP1", JdeDataType.String, 6),
        new JdeField("SYMOT", "SYMOT", JdeDataType.String, 6),
        new JdeField("SYCARS", "SYCARS", JdeDataType.Numeric),
        new JdeField("SYECST", "SYECST", JdeDataType.Numeric),
        new JdeField("SYCRDC", "SYCRDC", JdeDataType.String, 6),
        new JdeField("SYURCD", "SYURCD", JdeDataType.String, 4),
        new JdeField("SYURDT", "SYURDT", JdeDataType.Numeric),
        new JdeField("SYURAT", "SYURAT", JdeDataType.Numeric),
        new JdeField("SYURAB", "SYURAB", JdeDataType.Numeric),
        new JdeField("SYURRF", "SYURRF", JdeDataType.String, 30),
        new JdeField("SYTORG", "SYTORG", JdeDataType.String, 20),
        new JdeField("SYUSER", "SYUSER", JdeDataType.String, 20),
        new JdeField("SYPID", "SYPID", JdeDataType.String, 20),
        new JdeField("SYJOBN", "SYJOBN", JdeDataType.String, 20),
        new JdeField("SYUPMJ", "SYUPMJ", JdeDataType.Numeric),
        new JdeField("SYTDAY", "SYTDAY", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F4942Z1_0", "Primary Key on SYEDUS, SYEDBT, SYEDTN, SYEDLN", new[] { "SYEDUS", "SYEDBT", "SYEDTN", "SYEDLN" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F4942Z1_2", "Index on SYDOCO, SYDCTO, SYKCOO, SYLNID", new[] { "SYDOCO", "SYDCTO", "SYKCOO", "SYLNID" })
    };
}
