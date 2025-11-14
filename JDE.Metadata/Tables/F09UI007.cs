using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F09UI007 - .
/// </summary>
public class F09UI007 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// GLCN.
        /// </summary>
        public const string GLCN = "GLCN";

        /// <summary>
        /// GLAN8.
        /// </summary>
        public const string GLAN8 = "GLAN8";

        /// <summary>
        /// GLDK.
        /// </summary>
        public const string GLDK = "GLDK";

        /// <summary>
        /// GLAA.
        /// </summary>
        public const string GLAA = "GLAA";

        /// <summary>
        /// GLDKC.
        /// </summary>
        public const string GLDKC = "GLDKC";

        /// <summary>
        /// GLAA1.
        /// </summary>
        public const string GLAA1 = "GLAA1";

        /// <summary>
        /// GLAA2.
        /// </summary>
        public const string GLAA2 = "GLAA2";

        /// <summary>
        /// GLEV01.
        /// </summary>
        public const string GLEV01 = "GLEV01";

        /// <summary>
        /// GLUKID.
        /// </summary>
        public const string GLUKID = "GLUKID";

        /// <summary>
        /// GLSTBA.
        /// </summary>
        public const string GLSTBA = "GLSTBA";

        /// <summary>
        /// GLSTMD.
        /// </summary>
        public const string GLSTMD = "GLSTMD";

        /// <summary>
        /// GLICU.
        /// </summary>
        public const string GLICU = "GLICU";

        /// <summary>
        /// GLAID.
        /// </summary>
        public const string GLAID = "GLAID";

        /// <summary>
        /// GLJOBN.
        /// </summary>
        public const string GLJOBN = "GLJOBN";

        /// <summary>
        /// GLLT.
        /// </summary>
        public const string GLLT = "GLLT";

        /// <summary>
        /// GLCRCD.
        /// </summary>
        public const string GLCRCD = "GLCRCD";

        /// <summary>
        /// GLCO.
        /// </summary>
        public const string GLCO = "GLCO";

        /// <summary>
        /// GLAA3.
        /// </summary>
        public const string GLAA3 = "GLAA3";

        /// <summary>
        /// GLACR.
        /// </summary>
        public const string GLACR = "GLACR";
    }

    /// <inheritdoc />
    public override string TableName => "F09UI007";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("GLCN", "GLCN", JdeDataType.String, 16),
        new JdeField("GLAN8", "GLAN8", JdeDataType.Numeric),
        new JdeField("GLDK", "GLDK", JdeDataType.Numeric),
        new JdeField("GLAA", "GLAA", JdeDataType.Numeric),
        new JdeField("GLDKC", "GLDKC", JdeDataType.Numeric),
        new JdeField("GLAA1", "GLAA1", JdeDataType.Numeric),
        new JdeField("GLAA2", "GLAA2", JdeDataType.Numeric),
        new JdeField("GLEV01", "GLEV01", JdeDataType.String, 2),
        new JdeField("GLUKID", "GLUKID", JdeDataType.Numeric, null, true, true),
        new JdeField("GLSTBA", "GLSTBA", JdeDataType.String, 30),
        new JdeField("GLSTMD", "GLSTMD", JdeDataType.Numeric),
        new JdeField("GLICU", "GLICU", JdeDataType.Numeric),
        new JdeField("GLAID", "GLAID", JdeDataType.String, 16),
        new JdeField("GLJOBN", "GLJOBN", JdeDataType.String, 20, true, true),
        new JdeField("GLLT", "GLLT", JdeDataType.String, 4),
        new JdeField("GLCRCD", "GLCRCD", JdeDataType.String, 6),
        new JdeField("GLCO", "GLCO", JdeDataType.String, 10),
        new JdeField("GLAA3", "GLAA3", JdeDataType.Numeric),
        new JdeField("GLACR", "GLACR", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F09UI007_0", "Primary Key on GLJOBN, GLUKID", new[] { "GLJOBN", "GLUKID" }, isUnique: true, isPrimaryKey: true)
    };
}
