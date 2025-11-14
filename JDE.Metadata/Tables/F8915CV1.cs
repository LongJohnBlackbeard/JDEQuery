using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F8915CV1 - .
/// </summary>
public class F8915CV1 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// N7FILS.
        /// </summary>
        public const string N7FILS = "N7FILS";

        /// <summary>
        /// N7FILE.
        /// </summary>
        public const string N7FILE = "N7FILE";

        /// <summary>
        /// N7TOTALREC.
        /// </summary>
        public const string N7TOTALREC = "N7TOTALREC";

        /// <summary>
        /// N7MATH06.
        /// </summary>
        public const string N7MATH06 = "N7MATH06";

        /// <summary>
        /// N7MATH07.
        /// </summary>
        public const string N7MATH07 = "N7MATH07";

        /// <summary>
        /// N7MATH08.
        /// </summary>
        public const string N7MATH08 = "N7MATH08";

        /// <summary>
        /// N7MATH09.
        /// </summary>
        public const string N7MATH09 = "N7MATH09";

        /// <summary>
        /// N7MATH10.
        /// </summary>
        public const string N7MATH10 = "N7MATH10";

        /// <summary>
        /// N7DS01.
        /// </summary>
        public const string N7DS01 = "N7DS01";

        /// <summary>
        /// N7DL011.
        /// </summary>
        public const string N7DL011 = "N7DL011";

        /// <summary>
        /// N7UPMJ.
        /// </summary>
        public const string N7UPMJ = "N7UPMJ";

        /// <summary>
        /// N7UPMT.
        /// </summary>
        public const string N7UPMT = "N7UPMT";

        /// <summary>
        /// N7USER.
        /// </summary>
        public const string N7USER = "N7USER";

        /// <summary>
        /// N7JOBN.
        /// </summary>
        public const string N7JOBN = "N7JOBN";

        /// <summary>
        /// N7END.
        /// </summary>
        public const string N7END = "N7END";

        /// <summary>
        /// N7COTI.
        /// </summary>
        public const string N7COTI = "N7COTI";
    }

    /// <inheritdoc />
    public override string TableName => "F8915CV1";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("N7FILS", "N7FILS", JdeDataType.String, 20, true, true),
        new JdeField("N7FILE", "N7FILE", JdeDataType.String, 20, true, true),
        new JdeField("N7TOTALREC", "N7TOTALREC", JdeDataType.Numeric),
        new JdeField("N7MATH06", "N7MATH06", JdeDataType.Numeric),
        new JdeField("N7MATH07", "N7MATH07", JdeDataType.Numeric),
        new JdeField("N7MATH08", "N7MATH08", JdeDataType.Numeric),
        new JdeField("N7MATH09", "N7MATH09", JdeDataType.Numeric),
        new JdeField("N7MATH10", "N7MATH10", JdeDataType.Numeric),
        new JdeField("N7DS01", "N7DS01", JdeDataType.String, 160),
        new JdeField("N7DL011", "N7DL011", JdeDataType.String, 200),
        new JdeField("N7UPMJ", "N7UPMJ", JdeDataType.Numeric),
        new JdeField("N7UPMT", "N7UPMT", JdeDataType.Numeric),
        new JdeField("N7USER", "N7USER", JdeDataType.String, 20),
        new JdeField("N7JOBN", "N7JOBN", JdeDataType.String, 20),
        new JdeField("N7END", "N7END", JdeDataType.Numeric),
        new JdeField("N7COTI", "N7COTI", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F8915CV1_0", "Primary Key on N7FILS, N7FILE", new[] { "N7FILS", "N7FILE" }, isUnique: true, isPrimaryKey: true)
    };
}
