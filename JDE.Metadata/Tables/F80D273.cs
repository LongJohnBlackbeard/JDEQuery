using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F80D273 - .
/// </summary>
public class F80D273 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// PPPRDJ.
        /// </summary>
        public const string PPPRDJ = "PPPRDJ";

        /// <summary>
        /// PPCO.
        /// </summary>
        public const string PPCO = "PPCO";

        /// <summary>
        /// PPITM.
        /// </summary>
        public const string PPITM = "PPITM";

        /// <summary>
        /// PPAMPRF.
        /// </summary>
        public const string PPAMPRF = "PPAMPRF";

        /// <summary>
        /// PPUSER.
        /// </summary>
        public const string PPUSER = "PPUSER";

        /// <summary>
        /// PPPID.
        /// </summary>
        public const string PPPID = "PPPID";

        /// <summary>
        /// PPMKEY.
        /// </summary>
        public const string PPMKEY = "PPMKEY";

        /// <summary>
        /// PPUTIME.
        /// </summary>
        public const string PPUTIME = "PPUTIME";

        /// <summary>
        /// PPURCD.
        /// </summary>
        public const string PPURCD = "PPURCD";

        /// <summary>
        /// PPURDT.
        /// </summary>
        public const string PPURDT = "PPURDT";

        /// <summary>
        /// PPURAT.
        /// </summary>
        public const string PPURAT = "PPURAT";

        /// <summary>
        /// PPURAB.
        /// </summary>
        public const string PPURAB = "PPURAB";

        /// <summary>
        /// PPURRF.
        /// </summary>
        public const string PPURRF = "PPURRF";
    }

    /// <inheritdoc />
    public override string TableName => "F80D273";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("PPPRDJ", "PPPRDJ", JdeDataType.Numeric, null, true, true),
        new JdeField("PPCO", "PPCO", JdeDataType.String, 10, true, true),
        new JdeField("PPITM", "PPITM", JdeDataType.Numeric, null, true, true),
        new JdeField("PPAMPRF", "PPAMPRF", JdeDataType.Numeric),
        new JdeField("PPUSER", "PPUSER", JdeDataType.String, 20),
        new JdeField("PPPID", "PPPID", JdeDataType.String, 20),
        new JdeField("PPMKEY", "PPMKEY", JdeDataType.String, 30),
        new JdeField("PPUTIME", "PPUTIME", JdeDataType.Date),
        new JdeField("PPURCD", "PPURCD", JdeDataType.String, 4),
        new JdeField("PPURDT", "PPURDT", JdeDataType.Numeric),
        new JdeField("PPURAT", "PPURAT", JdeDataType.Numeric),
        new JdeField("PPURAB", "PPURAB", JdeDataType.Numeric),
        new JdeField("PPURRF", "PPURRF", JdeDataType.String, 30)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F80D273_0", "Primary Key on PPPRDJ, PPCO, PPITM", new[] { "PPPRDJ", "PPCO", "PPITM" }, isUnique: true, isPrimaryKey: true)
    };
}
