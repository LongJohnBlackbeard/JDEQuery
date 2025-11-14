using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F76A715 - .
/// </summary>
public class F76A715 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// PICO.
        /// </summary>
        public const string PICO = "PICO";

        /// <summary>
        /// PIADGI.
        /// </summary>
        public const string PIADGI = "PIADGI";

        /// <summary>
        /// PIACEM.
        /// </summary>
        public const string PIACEM = "PIACEM";

        /// <summary>
        /// PIARYO.
        /// </summary>
        public const string PIARYO = "PIARYO";

        /// <summary>
        /// PIEV01.
        /// </summary>
        public const string PIEV01 = "PIEV01";

        /// <summary>
        /// PIUSER.
        /// </summary>
        public const string PIUSER = "PIUSER";

        /// <summary>
        /// PIJOBN.
        /// </summary>
        public const string PIJOBN = "PIJOBN";

        /// <summary>
        /// PIUPMJ.
        /// </summary>
        public const string PIUPMJ = "PIUPMJ";

        /// <summary>
        /// PITDAY.
        /// </summary>
        public const string PITDAY = "PITDAY";

        /// <summary>
        /// PIADGI1.
        /// </summary>
        public const string PIADGI1 = "PIADGI1";

        /// <summary>
        /// PIACEM1.
        /// </summary>
        public const string PIACEM1 = "PIACEM1";
    }

    /// <inheritdoc />
    public override string TableName => "F76A715";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("PICO", "PICO", JdeDataType.String, 10, true, true),
        new JdeField("PIADGI", "PIADGI", JdeDataType.String, 4, true, true),
        new JdeField("PIACEM", "PIACEM", JdeDataType.String, 8, true, true),
        new JdeField("PIARYO", "PIARYO", JdeDataType.String, 2, true, true),
        new JdeField("PIEV01", "PIEV01", JdeDataType.String, 2),
        new JdeField("PIUSER", "PIUSER", JdeDataType.String, 20),
        new JdeField("PIJOBN", "PIJOBN", JdeDataType.String, 20),
        new JdeField("PIUPMJ", "PIUPMJ", JdeDataType.Numeric),
        new JdeField("PITDAY", "PITDAY", JdeDataType.Numeric),
        new JdeField("PIADGI1", "PIADGI1", JdeDataType.String, 20, true, true),
        new JdeField("PIACEM1", "PIACEM1", JdeDataType.String, 30, true, true)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F76A715_0", "Primary Key on PICO, PIADGI1, PIACEM1, PIARYO, PIADGI, PIACEM", new[] { "PICO", "PIADGI1", "PIACEM1", "PIARYO", "PIADGI", "PIACEM" }, isUnique: true, isPrimaryKey: true)
    };
}
