using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F0028 - .
/// </summary>
public class F0028 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// TETA1.
        /// </summary>
        public const string TETA1 = "TETA1";

        /// <summary>
        /// TETXR1.
        /// </summary>
        public const string TETXR1 = "TETXR1";

        /// <summary>
        /// TETOTO.
        /// </summary>
        public const string TETOTO = "TETOTO";

        /// <summary>
        /// TESRET.
        /// </summary>
        public const string TESRET = "TESRET";

        /// <summary>
        /// TEATXA.
        /// </summary>
        public const string TEATXA = "TEATXA";

        /// <summary>
        /// TEATXN.
        /// </summary>
        public const string TEATXN = "TEATXN";

        /// <summary>
        /// TETAXE.
        /// </summary>
        public const string TETAXE = "TETAXE";

        /// <summary>
        /// TESTAM.
        /// </summary>
        public const string TESTAM = "TESTAM";

        /// <summary>
        /// TECO.
        /// </summary>
        public const string TECO = "TECO";

        /// <summary>
        /// TEMCU.
        /// </summary>
        public const string TEMCU = "TEMCU";
    }

    /// <inheritdoc />
    public override string TableName => "F0028";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("TETA1", "TETA1", JdeDataType.Numeric, null, true, true),
        new JdeField("TETXR1", "TETXR1", JdeDataType.Numeric, null, true, true),
        new JdeField("TETOTO", "TETOTO", JdeDataType.Numeric),
        new JdeField("TESRET", "TESRET", JdeDataType.Numeric),
        new JdeField("TEATXA", "TEATXA", JdeDataType.Numeric),
        new JdeField("TEATXN", "TEATXN", JdeDataType.Numeric),
        new JdeField("TETAXE", "TETAXE", JdeDataType.Numeric),
        new JdeField("TESTAM", "TESTAM", JdeDataType.Numeric),
        new JdeField("TECO", "TECO", JdeDataType.String, 10, true, true),
        new JdeField("TEMCU", "TEMCU", JdeDataType.String, 24, true, true)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F0028_0", "Primary Key on TECO, TEMCU, TETA1, TETXR1", new[] { "TECO", "TEMCU", "TETA1", "TETXR1" }, isUnique: true, isPrimaryKey: true)
    };
}
