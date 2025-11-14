using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F76A30T - .
/// </summary>
public class F76A30T : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// V7EDUS.
        /// </summary>
        public const string V7EDUS = "V7EDUS";

        /// <summary>
        /// V7EDBT.
        /// </summary>
        public const string V7EDBT = "V7EDBT";

        /// <summary>
        /// V7EDTN.
        /// </summary>
        public const string V7EDTN = "V7EDTN";

        /// <summary>
        /// V7ACDS.
        /// </summary>
        public const string V7ACDS = "V7ACDS";

        /// <summary>
        /// V7ACOP.
        /// </summary>
        public const string V7ACOP = "V7ACOP";

        /// <summary>
        /// V7ACF.
        /// </summary>
        public const string V7ACF = "V7ACF";

        /// <summary>
        /// V7AIRG.
        /// </summary>
        public const string V7AIRG = "V7AIRG";

        /// <summary>
        /// V7AFCD.
        /// </summary>
        public const string V7AFCD = "V7AFCD";

        /// <summary>
        /// V7AFFE.
        /// </summary>
        public const string V7AFFE = "V7AFFE";

        /// <summary>
        /// V7AFAT.
        /// </summary>
        public const string V7AFAT = "V7AFAT";

        /// <summary>
        /// V7RP1.
        /// </summary>
        public const string V7RP1 = "V7RP1";

        /// <summary>
        /// V7ALTT.
        /// </summary>
        public const string V7ALTT = "V7ALTT";

        /// <summary>
        /// V7ALTU.
        /// </summary>
        public const string V7ALTU = "V7ALTU";

        /// <summary>
        /// V7ALTV.
        /// </summary>
        public const string V7ALTV = "V7ALTV";

        /// <summary>
        /// V7TRDJ.
        /// </summary>
        public const string V7TRDJ = "V7TRDJ";

        /// <summary>
        /// V7TORG.
        /// </summary>
        public const string V7TORG = "V7TORG";

        /// <summary>
        /// V7USER.
        /// </summary>
        public const string V7USER = "V7USER";

        /// <summary>
        /// V7PID.
        /// </summary>
        public const string V7PID = "V7PID";

        /// <summary>
        /// V7UPMJ.
        /// </summary>
        public const string V7UPMJ = "V7UPMJ";

        /// <summary>
        /// V7UPMT.
        /// </summary>
        public const string V7UPMT = "V7UPMT";

        /// <summary>
        /// V7JOBN.
        /// </summary>
        public const string V7JOBN = "V7JOBN";
    }

    /// <inheritdoc />
    public override string TableName => "F76A30T";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("V7EDUS", "V7EDUS", JdeDataType.String, 20, true, true),
        new JdeField("V7EDBT", "V7EDBT", JdeDataType.String, 30, true, true),
        new JdeField("V7EDTN", "V7EDTN", JdeDataType.String, 44, true, true),
        new JdeField("V7ACDS", "V7ACDS", JdeDataType.String, 8),
        new JdeField("V7ACOP", "V7ACOP", JdeDataType.String, 2),
        new JdeField("V7ACF", "V7ACF", JdeDataType.String, 2),
        new JdeField("V7AIRG", "V7AIRG", JdeDataType.String, 2),
        new JdeField("V7AFCD", "V7AFCD", JdeDataType.String, 20),
        new JdeField("V7AFFE", "V7AFFE", JdeDataType.Numeric),
        new JdeField("V7AFAT", "V7AFAT", JdeDataType.Numeric),
        new JdeField("V7RP1", "V7RP1", JdeDataType.String, 2),
        new JdeField("V7ALTT", "V7ALTT", JdeDataType.String, 2),
        new JdeField("V7ALTU", "V7ALTU", JdeDataType.String, 2),
        new JdeField("V7ALTV", "V7ALTV", JdeDataType.String, 2),
        new JdeField("V7TRDJ", "V7TRDJ", JdeDataType.Numeric),
        new JdeField("V7TORG", "V7TORG", JdeDataType.String, 20),
        new JdeField("V7USER", "V7USER", JdeDataType.String, 20),
        new JdeField("V7PID", "V7PID", JdeDataType.String, 20),
        new JdeField("V7UPMJ", "V7UPMJ", JdeDataType.Numeric),
        new JdeField("V7UPMT", "V7UPMT", JdeDataType.Numeric),
        new JdeField("V7JOBN", "V7JOBN", JdeDataType.String, 20)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F76A30T_0", "Primary Key on V7EDUS, V7EDBT, V7EDTN", new[] { "V7EDUS", "V7EDBT", "V7EDTN" }, isUnique: true, isPrimaryKey: true)
    };
}
