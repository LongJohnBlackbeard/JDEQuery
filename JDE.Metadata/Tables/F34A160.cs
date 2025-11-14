using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F34A160 - .
/// </summary>
public class F34A160 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// WRMCU.
        /// </summary>
        public const string WRMCU = "WRMCU";

        /// <summary>
        /// WRMMCU.
        /// </summary>
        public const string WRMMCU = "WRMMCU";

        /// <summary>
        /// WRRSETID.
        /// </summary>
        public const string WRRSETID = "WRRSETID";

        /// <summary>
        /// WRRSETD.
        /// </summary>
        public const string WRRSETD = "WRRSETD";

        /// <summary>
        /// WRURCD.
        /// </summary>
        public const string WRURCD = "WRURCD";

        /// <summary>
        /// WRURDT.
        /// </summary>
        public const string WRURDT = "WRURDT";

        /// <summary>
        /// WRURAT.
        /// </summary>
        public const string WRURAT = "WRURAT";

        /// <summary>
        /// WRURAB.
        /// </summary>
        public const string WRURAB = "WRURAB";

        /// <summary>
        /// WRURRF.
        /// </summary>
        public const string WRURRF = "WRURRF";

        /// <summary>
        /// WRUSER.
        /// </summary>
        public const string WRUSER = "WRUSER";

        /// <summary>
        /// WRMKEY.
        /// </summary>
        public const string WRMKEY = "WRMKEY";

        /// <summary>
        /// WRPID.
        /// </summary>
        public const string WRPID = "WRPID";

        /// <summary>
        /// WRUUPMJ.
        /// </summary>
        public const string WRUUPMJ = "WRUUPMJ";
    }

    /// <inheritdoc />
    public override string TableName => "F34A160";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("WRMCU", "WRMCU", JdeDataType.String, 24, true, true),
        new JdeField("WRMMCU", "WRMMCU", JdeDataType.String, 24, true, true),
        new JdeField("WRRSETID", "WRRSETID", JdeDataType.String, 20, true, true),
        new JdeField("WRRSETD", "WRRSETD", JdeDataType.String, 50),
        new JdeField("WRURCD", "WRURCD", JdeDataType.String, 4),
        new JdeField("WRURDT", "WRURDT", JdeDataType.Numeric),
        new JdeField("WRURAT", "WRURAT", JdeDataType.Numeric),
        new JdeField("WRURAB", "WRURAB", JdeDataType.Numeric),
        new JdeField("WRURRF", "WRURRF", JdeDataType.String, 30),
        new JdeField("WRUSER", "WRUSER", JdeDataType.String, 20),
        new JdeField("WRMKEY", "WRMKEY", JdeDataType.String, 30),
        new JdeField("WRPID", "WRPID", JdeDataType.String, 20),
        new JdeField("WRUUPMJ", "WRUUPMJ", JdeDataType.Date)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F34A160_0", "Primary Key on WRMMCU, WRMCU, WRRSETID", new[] { "WRMMCU", "WRMCU", "WRRSETID" }, isUnique: true, isPrimaryKey: true)
    };
}
