using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F80D107 - .
/// </summary>
public class F80D107 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// GDMETRIC.
        /// </summary>
        public const string GDMETRIC = "GDMETRIC";

        /// <summary>
        /// GDGDDV1.
        /// </summary>
        public const string GDGDDV1 = "GDGDDV1";

        /// <summary>
        /// GDGDDV2.
        /// </summary>
        public const string GDGDDV2 = "GDGDDV2";

        /// <summary>
        /// GDGDDV3.
        /// </summary>
        public const string GDGDDV3 = "GDGDDV3";

        /// <summary>
        /// GDGDDV4.
        /// </summary>
        public const string GDGDDV4 = "GDGDDV4";

        /// <summary>
        /// GDGDDV5.
        /// </summary>
        public const string GDGDDV5 = "GDGDDV5";

        /// <summary>
        /// GDGDDV6.
        /// </summary>
        public const string GDGDDV6 = "GDGDDV6";

        /// <summary>
        /// GDFMONTH.
        /// </summary>
        public const string GDFMONTH = "GDFMONTH";

        /// <summary>
        /// GDFYEAR.
        /// </summary>
        public const string GDFYEAR = "GDFYEAR";

        /// <summary>
        /// GDGOALVAL.
        /// </summary>
        public const string GDGOALVAL = "GDGOALVAL";

        /// <summary>
        /// GDUSER.
        /// </summary>
        public const string GDUSER = "GDUSER";

        /// <summary>
        /// GDPID.
        /// </summary>
        public const string GDPID = "GDPID";

        /// <summary>
        /// GDMKEY.
        /// </summary>
        public const string GDMKEY = "GDMKEY";

        /// <summary>
        /// GDUUPMJ.
        /// </summary>
        public const string GDUUPMJ = "GDUUPMJ";

        /// <summary>
        /// GDURCD.
        /// </summary>
        public const string GDURCD = "GDURCD";

        /// <summary>
        /// GDURDT.
        /// </summary>
        public const string GDURDT = "GDURDT";

        /// <summary>
        /// GDURAT.
        /// </summary>
        public const string GDURAT = "GDURAT";

        /// <summary>
        /// GDURAB.
        /// </summary>
        public const string GDURAB = "GDURAB";

        /// <summary>
        /// GDURRF.
        /// </summary>
        public const string GDURRF = "GDURRF";
    }

    /// <inheritdoc />
    public override string TableName => "F80D107";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("GDMETRIC", "GDMETRIC", JdeDataType.Numeric, null, true, true),
        new JdeField("GDGDDV1", "GDGDDV1", JdeDataType.String, 30, true, true),
        new JdeField("GDGDDV2", "GDGDDV2", JdeDataType.String, 30, true, true),
        new JdeField("GDGDDV3", "GDGDDV3", JdeDataType.String, 30, true, true),
        new JdeField("GDGDDV4", "GDGDDV4", JdeDataType.String, 30, true, true),
        new JdeField("GDGDDV5", "GDGDDV5", JdeDataType.String, 30, true, true),
        new JdeField("GDGDDV6", "GDGDDV6", JdeDataType.String, 30, true, true),
        new JdeField("GDFMONTH", "GDFMONTH", JdeDataType.Numeric, null, true, true),
        new JdeField("GDFYEAR", "GDFYEAR", JdeDataType.Numeric, null, true, true),
        new JdeField("GDGOALVAL", "GDGOALVAL", JdeDataType.Numeric),
        new JdeField("GDUSER", "GDUSER", JdeDataType.String, 20),
        new JdeField("GDPID", "GDPID", JdeDataType.String, 20),
        new JdeField("GDMKEY", "GDMKEY", JdeDataType.String, 30),
        new JdeField("GDUUPMJ", "GDUUPMJ", JdeDataType.Date),
        new JdeField("GDURCD", "GDURCD", JdeDataType.String, 4),
        new JdeField("GDURDT", "GDURDT", JdeDataType.Numeric),
        new JdeField("GDURAT", "GDURAT", JdeDataType.Numeric),
        new JdeField("GDURAB", "GDURAB", JdeDataType.Numeric),
        new JdeField("GDURRF", "GDURRF", JdeDataType.String, 30)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F80D107_0", "Primary Key on GDMETRIC, GDGDDV1, GDGDDV2, GDGDDV3, GDGDDV4, GDGDDV5, GDGDDV6, GDFMONTH, GDFYEAR", new[] { "GDMETRIC", "GDGDDV1", "GDGDDV2", "GDGDDV3", "GDGDDV4", "GDGDDV5", "GDGDDV6", "GDFMONTH", "GDFYEAR" }, isUnique: true, isPrimaryKey: true)
    };
}
