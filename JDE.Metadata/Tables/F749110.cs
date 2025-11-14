using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F749110 - .
/// </summary>
public class F749110 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// AGE74ACCG.
        /// </summary>
        public const string AGE74ACCG = "AGE74ACCG";

        /// <summary>
        /// AGE74RENA.
        /// </summary>
        public const string AGE74RENA = "AGE74RENA";

        /// <summary>
        /// AGE74AGD.
        /// </summary>
        public const string AGE74AGD = "AGE74AGD";

        /// <summary>
        /// AGE74AGT.
        /// </summary>
        public const string AGE74AGT = "AGE74AGT";

        /// <summary>
        /// AGE74GR1.
        /// </summary>
        public const string AGE74GR1 = "AGE74GR1";

        /// <summary>
        /// AGE74GR2.
        /// </summary>
        public const string AGE74GR2 = "AGE74GR2";

        /// <summary>
        /// AGE74GR3.
        /// </summary>
        public const string AGE74GR3 = "AGE74GR3";

        /// <summary>
        /// AGUSER.
        /// </summary>
        public const string AGUSER = "AGUSER";

        /// <summary>
        /// AGPID.
        /// </summary>
        public const string AGPID = "AGPID";

        /// <summary>
        /// AGJOBN.
        /// </summary>
        public const string AGJOBN = "AGJOBN";

        /// <summary>
        /// AGUPMJ.
        /// </summary>
        public const string AGUPMJ = "AGUPMJ";

        /// <summary>
        /// AGUPMT.
        /// </summary>
        public const string AGUPMT = "AGUPMT";
    }

    /// <inheritdoc />
    public override string TableName => "F749110";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("AGE74ACCG", "AGE74ACCG", JdeDataType.String, 30, true, true),
        new JdeField("AGE74RENA", "AGE74RENA", JdeDataType.String, 40),
        new JdeField("AGE74AGD", "AGE74AGD", JdeDataType.String, 60),
        new JdeField("AGE74AGT", "AGE74AGT", JdeDataType.String, 6),
        new JdeField("AGE74GR1", "AGE74GR1", JdeDataType.String, 60),
        new JdeField("AGE74GR2", "AGE74GR2", JdeDataType.String, 60),
        new JdeField("AGE74GR3", "AGE74GR3", JdeDataType.String, 60),
        new JdeField("AGUSER", "AGUSER", JdeDataType.String, 20),
        new JdeField("AGPID", "AGPID", JdeDataType.String, 20),
        new JdeField("AGJOBN", "AGJOBN", JdeDataType.String, 20),
        new JdeField("AGUPMJ", "AGUPMJ", JdeDataType.Numeric),
        new JdeField("AGUPMT", "AGUPMT", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F749110_0", "Primary Key on AGE74ACCG", new[] { "AGE74ACCG" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F749110_2", "Index on AGE74RENA", new[] { "AGE74RENA" })
    };
}
