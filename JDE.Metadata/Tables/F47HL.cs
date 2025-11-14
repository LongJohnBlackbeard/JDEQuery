using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F47HL - .
/// </summary>
public class F47HL : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// HLEDST.
        /// </summary>
        public const string HLEDST = "HLEDST";

        /// <summary>
        /// HLHLCF.
        /// </summary>
        public const string HLHLCF = "HLHLCF";

        /// <summary>
        /// HLHLSC.
        /// </summary>
        public const string HLHLSC = "HLHLSC";

        /// <summary>
        /// HLAN8.
        /// </summary>
        public const string HLAN8 = "HLAN8";

        /// <summary>
        /// HLSEQN.
        /// </summary>
        public const string HLSEQN = "HLSEQN";

        /// <summary>
        /// HLDTAS.
        /// </summary>
        public const string HLDTAS = "HLDTAS";

        /// <summary>
        /// HLDTAT.
        /// </summary>
        public const string HLDTAT = "HLDTAT";

        /// <summary>
        /// HLSAD.
        /// </summary>
        public const string HLSAD = "HLSAD";

        /// <summary>
        /// HLLTOT.
        /// </summary>
        public const string HLLTOT = "HLLTOT";

        /// <summary>
        /// HLADFL.
        /// </summary>
        public const string HLADFL = "HLADFL";

        /// <summary>
        /// HLTXFL.
        /// </summary>
        public const string HLTXFL = "HLTXFL";

        /// <summary>
        /// HLUSFL.
        /// </summary>
        public const string HLUSFL = "HLUSFL";

        /// <summary>
        /// HLUSER.
        /// </summary>
        public const string HLUSER = "HLUSER";

        /// <summary>
        /// HLPID.
        /// </summary>
        public const string HLPID = "HLPID";

        /// <summary>
        /// HLJOBN.
        /// </summary>
        public const string HLJOBN = "HLJOBN";

        /// <summary>
        /// HLUPMJ.
        /// </summary>
        public const string HLUPMJ = "HLUPMJ";

        /// <summary>
        /// HLTDAY.
        /// </summary>
        public const string HLTDAY = "HLTDAY";

        /// <summary>
        /// HLFLDN01.
        /// </summary>
        public const string HLFLDN01 = "HLFLDN01";
    }

    /// <inheritdoc />
    public override string TableName => "F47HL";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("HLEDST", "HLEDST", JdeDataType.String, 12, true, true),
        new JdeField("HLHLCF", "HLHLCF", JdeDataType.String, 36, true, true),
        new JdeField("HLHLSC", "HLHLSC", JdeDataType.String, 8),
        new JdeField("HLAN8", "HLAN8", JdeDataType.Numeric, null, true, true),
        new JdeField("HLSEQN", "HLSEQN", JdeDataType.Numeric, null, true, true),
        new JdeField("HLDTAS", "HLDTAS", JdeDataType.Numeric),
        new JdeField("HLDTAT", "HLDTAT", JdeDataType.String, 2),
        new JdeField("HLSAD", "HLSAD", JdeDataType.String, 2),
        new JdeField("HLLTOT", "HLLTOT", JdeDataType.Numeric),
        new JdeField("HLADFL", "HLADFL", JdeDataType.String, 2),
        new JdeField("HLTXFL", "HLTXFL", JdeDataType.String, 2),
        new JdeField("HLUSFL", "HLUSFL", JdeDataType.String, 2),
        new JdeField("HLUSER", "HLUSER", JdeDataType.String, 20),
        new JdeField("HLPID", "HLPID", JdeDataType.String, 20),
        new JdeField("HLJOBN", "HLJOBN", JdeDataType.String, 20),
        new JdeField("HLUPMJ", "HLUPMJ", JdeDataType.Numeric),
        new JdeField("HLTDAY", "HLTDAY", JdeDataType.Numeric),
        new JdeField("HLFLDN01", "HLFLDN01", JdeDataType.String, 24)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F47HL_0", "Primary Key on HLAN8, HLEDST, HLHLCF, HLSEQN", new[] { "HLAN8", "HLEDST", "HLHLCF", "HLSEQN" }, isUnique: true, isPrimaryKey: true)
    };
}
