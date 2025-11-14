using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F40G002 - .
/// </summary>
public class F40G002 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// GCGRMCU.
        /// </summary>
        public const string GCGRMCU = "GCGRMCU";

        /// <summary>
        /// GCHARPAT.
        /// </summary>
        public const string GCHARPAT = "GCHARPAT";

        /// <summary>
        /// GCQTYUOM.
        /// </summary>
        public const string GCQTYUOM = "GCQTYUOM";

        /// <summary>
        /// GCAREAUOM.
        /// </summary>
        public const string GCAREAUOM = "GCAREAUOM";

        /// <summary>
        /// GCVOLUM.
        /// </summary>
        public const string GCVOLUM = "GCVOLUM";

        /// <summary>
        /// GCELEVUOM.
        /// </summary>
        public const string GCELEVUOM = "GCELEVUOM";

        /// <summary>
        /// GCURCD.
        /// </summary>
        public const string GCURCD = "GCURCD";

        /// <summary>
        /// GCURDT.
        /// </summary>
        public const string GCURDT = "GCURDT";

        /// <summary>
        /// GCURRF.
        /// </summary>
        public const string GCURRF = "GCURRF";

        /// <summary>
        /// GCURAB.
        /// </summary>
        public const string GCURAB = "GCURAB";

        /// <summary>
        /// GCURAT.
        /// </summary>
        public const string GCURAT = "GCURAT";

        /// <summary>
        /// GCTORG.
        /// </summary>
        public const string GCTORG = "GCTORG";

        /// <summary>
        /// GCUSER.
        /// </summary>
        public const string GCUSER = "GCUSER";

        /// <summary>
        /// GCPID.
        /// </summary>
        public const string GCPID = "GCPID";

        /// <summary>
        /// GCJOBN.
        /// </summary>
        public const string GCJOBN = "GCJOBN";

        /// <summary>
        /// GCUUPMJ.
        /// </summary>
        public const string GCUUPMJ = "GCUUPMJ";
    }

    /// <inheritdoc />
    public override string TableName => "F40G002";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("GCGRMCU", "GCGRMCU", JdeDataType.String, 24, true, true),
        new JdeField("GCHARPAT", "GCHARPAT", JdeDataType.String, 20),
        new JdeField("GCQTYUOM", "GCQTYUOM", JdeDataType.String, 4),
        new JdeField("GCAREAUOM", "GCAREAUOM", JdeDataType.String, 4),
        new JdeField("GCVOLUM", "GCVOLUM", JdeDataType.String, 4),
        new JdeField("GCELEVUOM", "GCELEVUOM", JdeDataType.String, 4),
        new JdeField("GCURCD", "GCURCD", JdeDataType.String, 4),
        new JdeField("GCURDT", "GCURDT", JdeDataType.Numeric),
        new JdeField("GCURRF", "GCURRF", JdeDataType.String, 30),
        new JdeField("GCURAB", "GCURAB", JdeDataType.Numeric),
        new JdeField("GCURAT", "GCURAT", JdeDataType.Numeric),
        new JdeField("GCTORG", "GCTORG", JdeDataType.String, 20),
        new JdeField("GCUSER", "GCUSER", JdeDataType.String, 20),
        new JdeField("GCPID", "GCPID", JdeDataType.String, 20),
        new JdeField("GCJOBN", "GCJOBN", JdeDataType.String, 20),
        new JdeField("GCUUPMJ", "GCUUPMJ", JdeDataType.Date)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F40G002_0", "Primary Key on GCGRMCU", new[] { "GCGRMCU" }, isUnique: true, isPrimaryKey: true)
    };
}
