using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F03012A - .
/// </summary>
public class F03012A : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// A2AN8.
        /// </summary>
        public const string A2AN8 = "A2AN8";

        /// <summary>
        /// A2CO.
        /// </summary>
        public const string A2CO = "A2CO";

        /// <summary>
        /// A2EFTB.
        /// </summary>
        public const string A2EFTB = "A2EFTB";

        /// <summary>
        /// A2EFTF.
        /// </summary>
        public const string A2EFTF = "A2EFTF";

        /// <summary>
        /// A2AC01.
        /// </summary>
        public const string A2AC01 = "A2AC01";

        /// <summary>
        /// A2AC02.
        /// </summary>
        public const string A2AC02 = "A2AC02";

        /// <summary>
        /// A2AC03.
        /// </summary>
        public const string A2AC03 = "A2AC03";

        /// <summary>
        /// A2AC04.
        /// </summary>
        public const string A2AC04 = "A2AC04";

        /// <summary>
        /// A2AC05.
        /// </summary>
        public const string A2AC05 = "A2AC05";

        /// <summary>
        /// A2AC06.
        /// </summary>
        public const string A2AC06 = "A2AC06";

        /// <summary>
        /// A2AC07.
        /// </summary>
        public const string A2AC07 = "A2AC07";

        /// <summary>
        /// A2AC08.
        /// </summary>
        public const string A2AC08 = "A2AC08";

        /// <summary>
        /// A2AC09.
        /// </summary>
        public const string A2AC09 = "A2AC09";

        /// <summary>
        /// A2AC10.
        /// </summary>
        public const string A2AC10 = "A2AC10";

        /// <summary>
        /// A2AC11.
        /// </summary>
        public const string A2AC11 = "A2AC11";

        /// <summary>
        /// A2AC12.
        /// </summary>
        public const string A2AC12 = "A2AC12";

        /// <summary>
        /// A2AC13.
        /// </summary>
        public const string A2AC13 = "A2AC13";

        /// <summary>
        /// A2AC14.
        /// </summary>
        public const string A2AC14 = "A2AC14";

        /// <summary>
        /// A2AC15.
        /// </summary>
        public const string A2AC15 = "A2AC15";

        /// <summary>
        /// A2AC16.
        /// </summary>
        public const string A2AC16 = "A2AC16";

        /// <summary>
        /// A2AC17.
        /// </summary>
        public const string A2AC17 = "A2AC17";

        /// <summary>
        /// A2AC18.
        /// </summary>
        public const string A2AC18 = "A2AC18";

        /// <summary>
        /// A2AC19.
        /// </summary>
        public const string A2AC19 = "A2AC19";

        /// <summary>
        /// A2AC20.
        /// </summary>
        public const string A2AC20 = "A2AC20";

        /// <summary>
        /// A2AC21.
        /// </summary>
        public const string A2AC21 = "A2AC21";

        /// <summary>
        /// A2AC22.
        /// </summary>
        public const string A2AC22 = "A2AC22";

        /// <summary>
        /// A2AC23.
        /// </summary>
        public const string A2AC23 = "A2AC23";

        /// <summary>
        /// A2AC24.
        /// </summary>
        public const string A2AC24 = "A2AC24";

        /// <summary>
        /// A2AC25.
        /// </summary>
        public const string A2AC25 = "A2AC25";

        /// <summary>
        /// A2AC26.
        /// </summary>
        public const string A2AC26 = "A2AC26";

        /// <summary>
        /// A2AC27.
        /// </summary>
        public const string A2AC27 = "A2AC27";

        /// <summary>
        /// A2AC28.
        /// </summary>
        public const string A2AC28 = "A2AC28";

        /// <summary>
        /// A2AC29.
        /// </summary>
        public const string A2AC29 = "A2AC29";

        /// <summary>
        /// A2AC30.
        /// </summary>
        public const string A2AC30 = "A2AC30";

        /// <summary>
        /// A2USER.
        /// </summary>
        public const string A2USER = "A2USER";

        /// <summary>
        /// A2PID.
        /// </summary>
        public const string A2PID = "A2PID";

        /// <summary>
        /// A2UPMJ.
        /// </summary>
        public const string A2UPMJ = "A2UPMJ";

        /// <summary>
        /// A2UPMT.
        /// </summary>
        public const string A2UPMT = "A2UPMT";

        /// <summary>
        /// A2MKEY.
        /// </summary>
        public const string A2MKEY = "A2MKEY";
    }

    /// <inheritdoc />
    public override string TableName => "F03012A";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("A2AN8", "A2AN8", JdeDataType.Numeric, null, true, true),
        new JdeField("A2CO", "A2CO", JdeDataType.String, 10, true, true),
        new JdeField("A2EFTB", "A2EFTB", JdeDataType.Numeric, null, true, true),
        new JdeField("A2EFTF", "A2EFTF", JdeDataType.String, 2),
        new JdeField("A2AC01", "A2AC01", JdeDataType.String, 6),
        new JdeField("A2AC02", "A2AC02", JdeDataType.String, 6),
        new JdeField("A2AC03", "A2AC03", JdeDataType.String, 6),
        new JdeField("A2AC04", "A2AC04", JdeDataType.String, 6),
        new JdeField("A2AC05", "A2AC05", JdeDataType.String, 6),
        new JdeField("A2AC06", "A2AC06", JdeDataType.String, 6),
        new JdeField("A2AC07", "A2AC07", JdeDataType.String, 6),
        new JdeField("A2AC08", "A2AC08", JdeDataType.String, 6),
        new JdeField("A2AC09", "A2AC09", JdeDataType.String, 6),
        new JdeField("A2AC10", "A2AC10", JdeDataType.String, 6),
        new JdeField("A2AC11", "A2AC11", JdeDataType.String, 6),
        new JdeField("A2AC12", "A2AC12", JdeDataType.String, 6),
        new JdeField("A2AC13", "A2AC13", JdeDataType.String, 6),
        new JdeField("A2AC14", "A2AC14", JdeDataType.String, 6),
        new JdeField("A2AC15", "A2AC15", JdeDataType.String, 6),
        new JdeField("A2AC16", "A2AC16", JdeDataType.String, 6),
        new JdeField("A2AC17", "A2AC17", JdeDataType.String, 6),
        new JdeField("A2AC18", "A2AC18", JdeDataType.String, 6),
        new JdeField("A2AC19", "A2AC19", JdeDataType.String, 6),
        new JdeField("A2AC20", "A2AC20", JdeDataType.String, 6),
        new JdeField("A2AC21", "A2AC21", JdeDataType.String, 6),
        new JdeField("A2AC22", "A2AC22", JdeDataType.String, 6),
        new JdeField("A2AC23", "A2AC23", JdeDataType.String, 6),
        new JdeField("A2AC24", "A2AC24", JdeDataType.String, 6),
        new JdeField("A2AC25", "A2AC25", JdeDataType.String, 6),
        new JdeField("A2AC26", "A2AC26", JdeDataType.String, 6),
        new JdeField("A2AC27", "A2AC27", JdeDataType.String, 6),
        new JdeField("A2AC28", "A2AC28", JdeDataType.String, 6),
        new JdeField("A2AC29", "A2AC29", JdeDataType.String, 6),
        new JdeField("A2AC30", "A2AC30", JdeDataType.String, 6),
        new JdeField("A2USER", "A2USER", JdeDataType.String, 20),
        new JdeField("A2PID", "A2PID", JdeDataType.String, 20),
        new JdeField("A2UPMJ", "A2UPMJ", JdeDataType.Numeric),
        new JdeField("A2UPMT", "A2UPMT", JdeDataType.Numeric),
        new JdeField("A2MKEY", "A2MKEY", JdeDataType.String, 30)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F03012A_0", "Primary Key on A2AN8, A2CO, A2EFTB", new[] { "A2AN8", "A2CO", "A2EFTB" }, isUnique: true, isPrimaryKey: true)
    };
}
