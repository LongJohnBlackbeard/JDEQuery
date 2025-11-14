using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F3019 - .
/// </summary>
public class F3019 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// KRKID1.
        /// </summary>
        public const string KRKID1 = "KRKID1";

        /// <summary>
        /// KRSTRT.
        /// </summary>
        public const string KRSTRT = "KRSTRT";

        /// <summary>
        /// KRDRQJ.
        /// </summary>
        public const string KRDRQJ = "KRDRQJ";

        /// <summary>
        /// KRUORG.
        /// </summary>
        public const string KRUORG = "KRUORG";

        /// <summary>
        /// KRTRQT.
        /// </summary>
        public const string KRTRQT = "KRTRQT";

        /// <summary>
        /// KRUSER.
        /// </summary>
        public const string KRUSER = "KRUSER";

        /// <summary>
        /// KRPID.
        /// </summary>
        public const string KRPID = "KRPID";

        /// <summary>
        /// KRMKEY.
        /// </summary>
        public const string KRMKEY = "KRMKEY";

        /// <summary>
        /// KRUPMJ.
        /// </summary>
        public const string KRUPMJ = "KRUPMJ";

        /// <summary>
        /// KRUPMT.
        /// </summary>
        public const string KRUPMT = "KRUPMT";
    }

    /// <inheritdoc />
    public override string TableName => "F3019";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("KRKID1", "KRKID1", JdeDataType.Numeric, null, true, true),
        new JdeField("KRSTRT", "KRSTRT", JdeDataType.Numeric),
        new JdeField("KRDRQJ", "KRDRQJ", JdeDataType.Numeric),
        new JdeField("KRUORG", "KRUORG", JdeDataType.Numeric),
        new JdeField("KRTRQT", "KRTRQT", JdeDataType.Numeric),
        new JdeField("KRUSER", "KRUSER", JdeDataType.String, 20),
        new JdeField("KRPID", "KRPID", JdeDataType.String, 20),
        new JdeField("KRMKEY", "KRMKEY", JdeDataType.String, 30),
        new JdeField("KRUPMJ", "KRUPMJ", JdeDataType.Numeric),
        new JdeField("KRUPMT", "KRUPMT", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F3019_0", "Primary Key on KRKID1", new[] { "KRKID1" }, isUnique: true, isPrimaryKey: true)
    };
}
