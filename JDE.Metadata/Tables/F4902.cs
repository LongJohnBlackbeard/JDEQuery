using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F4902 - .
/// </summary>
public class F4902 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// TVVEHI.
        /// </summary>
        public const string TVVEHI = "TVVEHI";

        /// <summary>
        /// TVRLNO.
        /// </summary>
        public const string TVRLNO = "TVRLNO";

        /// <summary>
        /// TVDUMV.
        /// </summary>
        public const string TVDUMV = "TVDUMV";

        /// <summary>
        /// TVVMCU.
        /// </summary>
        public const string TVVMCU = "TVVMCU";

        /// <summary>
        /// TVTRP.
        /// </summary>
        public const string TVTRP = "TVTRP";

        /// <summary>
        /// TVLMCU.
        /// </summary>
        public const string TVLMCU = "TVLMCU";

        /// <summary>
        /// TVLTRP.
        /// </summary>
        public const string TVLTRP = "TVLTRP";

        /// <summary>
        /// TVURCD.
        /// </summary>
        public const string TVURCD = "TVURCD";

        /// <summary>
        /// TVURDT.
        /// </summary>
        public const string TVURDT = "TVURDT";

        /// <summary>
        /// TVURAT.
        /// </summary>
        public const string TVURAT = "TVURAT";

        /// <summary>
        /// TVURAB.
        /// </summary>
        public const string TVURAB = "TVURAB";

        /// <summary>
        /// TVURRF.
        /// </summary>
        public const string TVURRF = "TVURRF";

        /// <summary>
        /// TVUSER.
        /// </summary>
        public const string TVUSER = "TVUSER";

        /// <summary>
        /// TVPID.
        /// </summary>
        public const string TVPID = "TVPID";

        /// <summary>
        /// TVJOBN.
        /// </summary>
        public const string TVJOBN = "TVJOBN";

        /// <summary>
        /// TVUPMJ.
        /// </summary>
        public const string TVUPMJ = "TVUPMJ";

        /// <summary>
        /// TVTDAY.
        /// </summary>
        public const string TVTDAY = "TVTDAY";
    }

    /// <inheritdoc />
    public override string TableName => "F4902";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("TVVEHI", "TVVEHI", JdeDataType.String, 24, true, true),
        new JdeField("TVRLNO", "TVRLNO", JdeDataType.String, 26, true, true),
        new JdeField("TVDUMV", "TVDUMV", JdeDataType.String, 2),
        new JdeField("TVVMCU", "TVVMCU", JdeDataType.String, 24),
        new JdeField("TVTRP", "TVTRP", JdeDataType.Numeric),
        new JdeField("TVLMCU", "TVLMCU", JdeDataType.String, 24),
        new JdeField("TVLTRP", "TVLTRP", JdeDataType.Numeric),
        new JdeField("TVURCD", "TVURCD", JdeDataType.String, 4),
        new JdeField("TVURDT", "TVURDT", JdeDataType.Numeric),
        new JdeField("TVURAT", "TVURAT", JdeDataType.Numeric),
        new JdeField("TVURAB", "TVURAB", JdeDataType.Numeric),
        new JdeField("TVURRF", "TVURRF", JdeDataType.String, 30),
        new JdeField("TVUSER", "TVUSER", JdeDataType.String, 20),
        new JdeField("TVPID", "TVPID", JdeDataType.String, 20),
        new JdeField("TVJOBN", "TVJOBN", JdeDataType.String, 20),
        new JdeField("TVUPMJ", "TVUPMJ", JdeDataType.Numeric),
        new JdeField("TVTDAY", "TVTDAY", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F4902_0", "Primary Key on TVVEHI, TVRLNO", new[] { "TVVEHI", "TVRLNO" }, isUnique: true, isPrimaryKey: true)
    };
}
