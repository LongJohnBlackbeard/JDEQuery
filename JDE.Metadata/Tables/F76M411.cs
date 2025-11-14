using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F76M411 - .
/// </summary>
public class F76M411 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// RSKCO.
        /// </summary>
        public const string RSKCO = "RSKCO";

        /// <summary>
        /// RSDOC.
        /// </summary>
        public const string RSDOC = "RSDOC";

        /// <summary>
        /// RSDCT.
        /// </summary>
        public const string RSDCT = "RSDCT";

        /// <summary>
        /// RSSFX.
        /// </summary>
        public const string RSSFX = "RSSFX";

        /// <summary>
        /// RSSFXE.
        /// </summary>
        public const string RSSFXE = "RSSFXE";

        /// <summary>
        /// RSCO.
        /// </summary>
        public const string RSCO = "RSCO";

        /// <summary>
        /// RSDREM.
        /// </summary>
        public const string RSDREM = "RSDREM";

        /// <summary>
        /// RSDFRE.
        /// </summary>
        public const string RSDFRE = "RSDFRE";

        /// <summary>
        /// RSSTAM.
        /// </summary>
        public const string RSSTAM = "RSSTAM";

        /// <summary>
        /// RSBCRC.
        /// </summary>
        public const string RSBCRC = "RSBCRC";

        /// <summary>
        /// RSCTAM.
        /// </summary>
        public const string RSCTAM = "RSCTAM";

        /// <summary>
        /// RSCRCD.
        /// </summary>
        public const string RSCRCD = "RSCRCD";

        /// <summary>
        /// RSGFL1.
        /// </summary>
        public const string RSGFL1 = "RSGFL1";

        /// <summary>
        /// RSUSER.
        /// </summary>
        public const string RSUSER = "RSUSER";

        /// <summary>
        /// RSTORG.
        /// </summary>
        public const string RSTORG = "RSTORG";

        /// <summary>
        /// RSPID.
        /// </summary>
        public const string RSPID = "RSPID";

        /// <summary>
        /// RSJOBN.
        /// </summary>
        public const string RSJOBN = "RSJOBN";

        /// <summary>
        /// RSUPMJ.
        /// </summary>
        public const string RSUPMJ = "RSUPMJ";

        /// <summary>
        /// RSUPMT.
        /// </summary>
        public const string RSUPMT = "RSUPMT";
    }

    /// <inheritdoc />
    public override string TableName => "F76M411";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("RSKCO", "RSKCO", JdeDataType.String, 10, true, true),
        new JdeField("RSDOC", "RSDOC", JdeDataType.Numeric, null, true, true),
        new JdeField("RSDCT", "RSDCT", JdeDataType.String, 4, true, true),
        new JdeField("RSSFX", "RSSFX", JdeDataType.String, 6, true, true),
        new JdeField("RSSFXE", "RSSFXE", JdeDataType.Numeric, null, true, true),
        new JdeField("RSCO", "RSCO", JdeDataType.String, 10),
        new JdeField("RSDREM", "RSDREM", JdeDataType.Numeric),
        new JdeField("RSDFRE", "RSDFRE", JdeDataType.Numeric),
        new JdeField("RSSTAM", "RSSTAM", JdeDataType.Numeric),
        new JdeField("RSBCRC", "RSBCRC", JdeDataType.String, 6),
        new JdeField("RSCTAM", "RSCTAM", JdeDataType.Numeric),
        new JdeField("RSCRCD", "RSCRCD", JdeDataType.String, 6),
        new JdeField("RSGFL1", "RSGFL1", JdeDataType.String, 2),
        new JdeField("RSUSER", "RSUSER", JdeDataType.String, 20),
        new JdeField("RSTORG", "RSTORG", JdeDataType.String, 20),
        new JdeField("RSPID", "RSPID", JdeDataType.String, 20),
        new JdeField("RSJOBN", "RSJOBN", JdeDataType.String, 20),
        new JdeField("RSUPMJ", "RSUPMJ", JdeDataType.Numeric),
        new JdeField("RSUPMT", "RSUPMT", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F76M411_0", "Primary Key on RSDOC, RSDCT, RSKCO, RSSFX, RSSFXE", new[] { "RSDOC", "RSDCT", "RSKCO", "RSSFX", "RSSFXE" }, isUnique: true, isPrimaryKey: true)
    };
}
