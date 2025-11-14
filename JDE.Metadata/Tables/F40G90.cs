using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F40G90 - .
/// </summary>
public class F40G90 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// PIITM.
        /// </summary>
        public const string PIITM = "PIITM";

        /// <summary>
        /// PILITM.
        /// </summary>
        public const string PILITM = "PILITM";

        /// <summary>
        /// PIAITM.
        /// </summary>
        public const string PIAITM = "PIAITM";

        /// <summary>
        /// PIMCU.
        /// </summary>
        public const string PIMCU = "PIMCU";

        /// <summary>
        /// PIALLBP.
        /// </summary>
        public const string PIALLBP = "PIALLBP";

        /// <summary>
        /// PIURAB.
        /// </summary>
        public const string PIURAB = "PIURAB";

        /// <summary>
        /// PIURAT.
        /// </summary>
        public const string PIURAT = "PIURAT";

        /// <summary>
        /// PIURCD.
        /// </summary>
        public const string PIURCD = "PIURCD";

        /// <summary>
        /// PIURDT.
        /// </summary>
        public const string PIURDT = "PIURDT";

        /// <summary>
        /// PIURRF.
        /// </summary>
        public const string PIURRF = "PIURRF";

        /// <summary>
        /// PIUSER.
        /// </summary>
        public const string PIUSER = "PIUSER";

        /// <summary>
        /// PIPID.
        /// </summary>
        public const string PIPID = "PIPID";

        /// <summary>
        /// PIJOBN.
        /// </summary>
        public const string PIJOBN = "PIJOBN";

        /// <summary>
        /// PITORG.
        /// </summary>
        public const string PITORG = "PITORG";

        /// <summary>
        /// PIUUPMJ.
        /// </summary>
        public const string PIUUPMJ = "PIUUPMJ";
    }

    /// <inheritdoc />
    public override string TableName => "F40G90";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("PIITM", "PIITM", JdeDataType.Numeric, null, true, true),
        new JdeField("PILITM", "PILITM", JdeDataType.String, 50),
        new JdeField("PIAITM", "PIAITM", JdeDataType.String, 50),
        new JdeField("PIMCU", "PIMCU", JdeDataType.String, 24, true, true),
        new JdeField("PIALLBP", "PIALLBP", JdeDataType.String, 2, true, true),
        new JdeField("PIURAB", "PIURAB", JdeDataType.Numeric),
        new JdeField("PIURAT", "PIURAT", JdeDataType.Numeric),
        new JdeField("PIURCD", "PIURCD", JdeDataType.String, 4),
        new JdeField("PIURDT", "PIURDT", JdeDataType.Numeric),
        new JdeField("PIURRF", "PIURRF", JdeDataType.String, 30),
        new JdeField("PIUSER", "PIUSER", JdeDataType.String, 20),
        new JdeField("PIPID", "PIPID", JdeDataType.String, 20),
        new JdeField("PIJOBN", "PIJOBN", JdeDataType.String, 20),
        new JdeField("PITORG", "PITORG", JdeDataType.String, 20),
        new JdeField("PIUUPMJ", "PIUUPMJ", JdeDataType.Date)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F40G90_0", "Primary Key on PIITM, PIMCU, PIALLBP", new[] { "PIITM", "PIMCU", "PIALLBP" }, isUnique: true, isPrimaryKey: true)
    };
}
