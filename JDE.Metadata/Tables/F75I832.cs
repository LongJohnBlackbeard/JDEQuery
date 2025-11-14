using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F75I832 - .
/// </summary>
public class F75I832 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// ERI75INVNO.
        /// </summary>
        public const string ERI75INVNO = "ERI75INVNO";

        /// <summary>
        /// ERI75GERN.
        /// </summary>
        public const string ERI75GERN = "ERI75GERN";

        /// <summary>
        /// ERKCO.
        /// </summary>
        public const string ERKCO = "ERKCO";

        /// <summary>
        /// ERDCT.
        /// </summary>
        public const string ERDCT = "ERDCT";

        /// <summary>
        /// ERDOC.
        /// </summary>
        public const string ERDOC = "ERDOC";

        /// <summary>
        /// ERAN8.
        /// </summary>
        public const string ERAN8 = "ERAN8";

        /// <summary>
        /// ERI75GSTU.
        /// </summary>
        public const string ERI75GSTU = "ERI75GSTU";

        /// <summary>
        /// ERDGL.
        /// </summary>
        public const string ERDGL = "ERDGL";

        /// <summary>
        /// ERUSER.
        /// </summary>
        public const string ERUSER = "ERUSER";

        /// <summary>
        /// ERPID.
        /// </summary>
        public const string ERPID = "ERPID";

        /// <summary>
        /// ERJOBN.
        /// </summary>
        public const string ERJOBN = "ERJOBN";

        /// <summary>
        /// ERUPMJ.
        /// </summary>
        public const string ERUPMJ = "ERUPMJ";

        /// <summary>
        /// ERUPMT.
        /// </summary>
        public const string ERUPMT = "ERUPMT";

        /// <summary>
        /// ERYFUTDT1.
        /// </summary>
        public const string ERYFUTDT1 = "ERYFUTDT1";

        /// <summary>
        /// ERFUT6.
        /// </summary>
        public const string ERFUT6 = "ERFUT6";

        /// <summary>
        /// ERYT04.
        /// </summary>
        public const string ERYT04 = "ERYT04";

        /// <summary>
        /// ERYFLAG.
        /// </summary>
        public const string ERYFLAG = "ERYFLAG";

        /// <summary>
        /// ERYNUM1.
        /// </summary>
        public const string ERYNUM1 = "ERYNUM1";
    }

    /// <inheritdoc />
    public override string TableName => "F75I832";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("ERI75INVNO", "ERI75INVNO", JdeDataType.String, 50, true, true),
        new JdeField("ERI75GERN", "ERI75GERN", JdeDataType.String, 80),
        new JdeField("ERKCO", "ERKCO", JdeDataType.String, 10),
        new JdeField("ERDCT", "ERDCT", JdeDataType.String, 4),
        new JdeField("ERDOC", "ERDOC", JdeDataType.Numeric),
        new JdeField("ERAN8", "ERAN8", JdeDataType.Numeric),
        new JdeField("ERI75GSTU", "ERI75GSTU", JdeDataType.Numeric),
        new JdeField("ERDGL", "ERDGL", JdeDataType.Numeric),
        new JdeField("ERUSER", "ERUSER", JdeDataType.String, 20),
        new JdeField("ERPID", "ERPID", JdeDataType.String, 20),
        new JdeField("ERJOBN", "ERJOBN", JdeDataType.String, 20),
        new JdeField("ERUPMJ", "ERUPMJ", JdeDataType.Numeric),
        new JdeField("ERUPMT", "ERUPMT", JdeDataType.Numeric),
        new JdeField("ERYFUTDT1", "ERYFUTDT1", JdeDataType.Numeric),
        new JdeField("ERFUT6", "ERFUT6", JdeDataType.String, 60),
        new JdeField("ERYT04", "ERYT04", JdeDataType.String, 2),
        new JdeField("ERYFLAG", "ERYFLAG", JdeDataType.String, 2),
        new JdeField("ERYNUM1", "ERYNUM1", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F75I832_0", "Primary Key on ERI75INVNO", new[] { "ERI75INVNO" }, isUnique: true, isPrimaryKey: true)
    };
}
