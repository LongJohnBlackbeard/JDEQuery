using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F31B103 - .
/// </summary>
public class F31B103 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// UVWVID.
        /// </summary>
        public const string UVWVID = "UVWVID";

        /// <summary>
        /// UVWUVNUM.
        /// </summary>
        public const string UVWUVNUM = "UVWUVNUM";

        /// <summary>
        /// UVWUVD.
        /// </summary>
        public const string UVWUVD = "UVWUVD";

        /// <summary>
        /// UVMCU.
        /// </summary>
        public const string UVMCU = "UVMCU";

        /// <summary>
        /// UVWUVSTAT.
        /// </summary>
        public const string UVWUVSTAT = "UVWUVSTAT";

        /// <summary>
        /// UVURAT.
        /// </summary>
        public const string UVURAT = "UVURAT";

        /// <summary>
        /// UVURCD.
        /// </summary>
        public const string UVURCD = "UVURCD";

        /// <summary>
        /// UVURDT.
        /// </summary>
        public const string UVURDT = "UVURDT";

        /// <summary>
        /// UVURAB.
        /// </summary>
        public const string UVURAB = "UVURAB";

        /// <summary>
        /// UVURRF.
        /// </summary>
        public const string UVURRF = "UVURRF";

        /// <summary>
        /// UVUSER.
        /// </summary>
        public const string UVUSER = "UVUSER";

        /// <summary>
        /// UVPID.
        /// </summary>
        public const string UVPID = "UVPID";

        /// <summary>
        /// UVJOBN.
        /// </summary>
        public const string UVJOBN = "UVJOBN";

        /// <summary>
        /// UVUPMJ.
        /// </summary>
        public const string UVUPMJ = "UVUPMJ";

        /// <summary>
        /// UVTDAY.
        /// </summary>
        public const string UVTDAY = "UVTDAY";
    }

    /// <inheritdoc />
    public override string TableName => "F31B103";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("UVWVID", "UVWVID", JdeDataType.Numeric, null, true, true),
        new JdeField("UVWUVNUM", "UVWUVNUM", JdeDataType.String, 60),
        new JdeField("UVWUVD", "UVWUVD", JdeDataType.String, 60),
        new JdeField("UVMCU", "UVMCU", JdeDataType.String, 24),
        new JdeField("UVWUVSTAT", "UVWUVSTAT", JdeDataType.String, 2),
        new JdeField("UVURAT", "UVURAT", JdeDataType.Numeric),
        new JdeField("UVURCD", "UVURCD", JdeDataType.String, 4),
        new JdeField("UVURDT", "UVURDT", JdeDataType.Numeric),
        new JdeField("UVURAB", "UVURAB", JdeDataType.Numeric),
        new JdeField("UVURRF", "UVURRF", JdeDataType.String, 30),
        new JdeField("UVUSER", "UVUSER", JdeDataType.String, 20),
        new JdeField("UVPID", "UVPID", JdeDataType.String, 20),
        new JdeField("UVJOBN", "UVJOBN", JdeDataType.String, 20),
        new JdeField("UVUPMJ", "UVUPMJ", JdeDataType.Numeric),
        new JdeField("UVTDAY", "UVTDAY", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F31B103_0", "Primary Key on UVWVID", new[] { "UVWVID" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F31B103_2", "Index on UVWUVNUM", new[] { "UVWUVNUM" })
    };
}
