using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F06166B - .
/// </summary>
public class F06166B : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// YVAN8.
        /// </summary>
        public const string YVAN8 = "YVAN8";

        /// <summary>
        /// YVCKCN.
        /// </summary>
        public const string YVCKCN = "YVCKCN";

        /// <summary>
        /// YVTHTY.
        /// </summary>
        public const string YVTHTY = "YVTHTY";

        /// <summary>
        /// YVTARA.
        /// </summary>
        public const string YVTARA = "YVTARA";

        /// <summary>
        /// YVPTAX.
        /// </summary>
        public const string YVPTAX = "YVPTAX";

        /// <summary>
        /// YVSCDC.
        /// </summary>
        public const string YVSCDC = "YVSCDC";

        /// <summary>
        /// YVINTEGER.
        /// </summary>
        public const string YVINTEGER = "YVINTEGER";

        /// <summary>
        /// YVGPAY.
        /// </summary>
        public const string YVGPAY = "YVGPAY";

        /// <summary>
        /// YVG301.
        /// </summary>
        public const string YVG301 = "YVG301";

        /// <summary>
        /// YVWE01.
        /// </summary>
        public const string YVWE01 = "YVWE01";

        /// <summary>
        /// YVWX01.
        /// </summary>
        public const string YVWX01 = "YVWX01";

        /// <summary>
        /// YVHMCO.
        /// </summary>
        public const string YVHMCO = "YVHMCO";

        /// <summary>
        /// YVTAXX.
        /// </summary>
        public const string YVTAXX = "YVTAXX";

        /// <summary>
        /// YVHMO.
        /// </summary>
        public const string YVHMO = "YVHMO";

        /// <summary>
        /// YVCKDT.
        /// </summary>
        public const string YVCKDT = "YVCKDT";

        /// <summary>
        /// YVTXOF.
        /// </summary>
        public const string YVTXOF = "YVTXOF";

        /// <summary>
        /// YVRTAM.
        /// </summary>
        public const string YVRTAM = "YVRTAM";

        /// <summary>
        /// YVMATH01.
        /// </summary>
        public const string YVMATH01 = "YVMATH01";

        /// <summary>
        /// YVMATH02.
        /// </summary>
        public const string YVMATH02 = "YVMATH02";

        /// <summary>
        /// YVMATH03.
        /// </summary>
        public const string YVMATH03 = "YVMATH03";

        /// <summary>
        /// YVINT01.
        /// </summary>
        public const string YVINT01 = "YVINT01";

        /// <summary>
        /// YVINT02.
        /// </summary>
        public const string YVINT02 = "YVINT02";

        /// <summary>
        /// YVINT03.
        /// </summary>
        public const string YVINT03 = "YVINT03";

        /// <summary>
        /// YVDESC.
        /// </summary>
        public const string YVDESC = "YVDESC";

        /// <summary>
        /// YVDESC02.
        /// </summary>
        public const string YVDESC02 = "YVDESC02";

        /// <summary>
        /// YVDESC3.
        /// </summary>
        public const string YVDESC3 = "YVDESC3";

        /// <summary>
        /// YVJOBN.
        /// </summary>
        public const string YVJOBN = "YVJOBN";

        /// <summary>
        /// YVUSER.
        /// </summary>
        public const string YVUSER = "YVUSER";

        /// <summary>
        /// YVUPMJ.
        /// </summary>
        public const string YVUPMJ = "YVUPMJ";

        /// <summary>
        /// YVUPMT.
        /// </summary>
        public const string YVUPMT = "YVUPMT";

        /// <summary>
        /// YVPID.
        /// </summary>
        public const string YVPID = "YVPID";
    }

    /// <inheritdoc />
    public override string TableName => "F06166B";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("YVAN8", "YVAN8", JdeDataType.Numeric, null, true, true),
        new JdeField("YVCKCN", "YVCKCN", JdeDataType.Numeric, null, true, true),
        new JdeField("YVTHTY", "YVTHTY", JdeDataType.String, 2, true, true),
        new JdeField("YVTARA", "YVTARA", JdeDataType.String, 20, true, true),
        new JdeField("YVPTAX", "YVPTAX", JdeDataType.String, 4, true, true),
        new JdeField("YVSCDC", "YVSCDC", JdeDataType.Numeric, null, true, true),
        new JdeField("YVINTEGER", "YVINTEGER", JdeDataType.Numeric, null, true, true),
        new JdeField("YVGPAY", "YVGPAY", JdeDataType.Numeric),
        new JdeField("YVG301", "YVG301", JdeDataType.Numeric),
        new JdeField("YVWE01", "YVWE01", JdeDataType.Numeric),
        new JdeField("YVWX01", "YVWX01", JdeDataType.Numeric),
        new JdeField("YVHMCO", "YVHMCO", JdeDataType.String, 10),
        new JdeField("YVTAXX", "YVTAXX", JdeDataType.String, 40),
        new JdeField("YVHMO", "YVHMO", JdeDataType.Numeric),
        new JdeField("YVCKDT", "YVCKDT", JdeDataType.Numeric),
        new JdeField("YVTXOF", "YVTXOF", JdeDataType.String, 2),
        new JdeField("YVRTAM", "YVRTAM", JdeDataType.Numeric),
        new JdeField("YVMATH01", "YVMATH01", JdeDataType.Numeric),
        new JdeField("YVMATH02", "YVMATH02", JdeDataType.Numeric),
        new JdeField("YVMATH03", "YVMATH03", JdeDataType.Numeric),
        new JdeField("YVINT01", "YVINT01", JdeDataType.Numeric),
        new JdeField("YVINT02", "YVINT02", JdeDataType.Numeric),
        new JdeField("YVINT03", "YVINT03", JdeDataType.Numeric),
        new JdeField("YVDESC", "YVDESC", JdeDataType.String, 60),
        new JdeField("YVDESC02", "YVDESC02", JdeDataType.String, 90),
        new JdeField("YVDESC3", "YVDESC3", JdeDataType.String, 60),
        new JdeField("YVJOBN", "YVJOBN", JdeDataType.String, 20),
        new JdeField("YVUSER", "YVUSER", JdeDataType.String, 20),
        new JdeField("YVUPMJ", "YVUPMJ", JdeDataType.Numeric),
        new JdeField("YVUPMT", "YVUPMT", JdeDataType.Numeric),
        new JdeField("YVPID", "YVPID", JdeDataType.String, 20)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F06166B_0", "Primary Key on YVAN8, YVCKCN, YVTHTY, YVTARA, YVPTAX, YVSCDC, YVINTEGER", new[] { "YVAN8", "YVCKCN", "YVTHTY", "YVTARA", "YVPTAX", "YVSCDC", "YVINTEGER" }, isUnique: true, isPrimaryKey: true)
    };
}
