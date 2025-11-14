using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F40G102 - .
/// </summary>
public class F40G102 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// GCGRECID.
        /// </summary>
        public const string GCGRECID = "GCGRECID";

        /// <summary>
        /// GCRECTYP.
        /// </summary>
        public const string GCRECTYP = "GCRECTYP";

        /// <summary>
        /// GCAN8TYPE.
        /// </summary>
        public const string GCAN8TYPE = "GCAN8TYPE";

        /// <summary>
        /// GCAN8.
        /// </summary>
        public const string GCAN8 = "GCAN8";

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
    public override string TableName => "F40G102";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("GCGRECID", "GCGRECID", JdeDataType.Numeric, null, true, true),
        new JdeField("GCRECTYP", "GCRECTYP", JdeDataType.String, 2, true, true),
        new JdeField("GCAN8TYPE", "GCAN8TYPE", JdeDataType.String, 6, true, true),
        new JdeField("GCAN8", "GCAN8", JdeDataType.Numeric, null, true, true),
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
        new JdeIndex("F40G102_0", "Primary Key on GCGRECID, GCRECTYP, GCAN8TYPE, GCAN8", new[] { "GCGRECID", "GCRECTYP", "GCAN8TYPE", "GCAN8" }, isUnique: true, isPrimaryKey: true)
    };
}
