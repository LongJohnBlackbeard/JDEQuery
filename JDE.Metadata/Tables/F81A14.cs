using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F81A14 - .
/// </summary>
public class F81A14 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// M6LDFR.
        /// </summary>
        public const string M6LDFR = "M6LDFR";

        /// <summary>
        /// M6PID.
        /// </summary>
        public const string M6PID = "M6PID";

        /// <summary>
        /// M6VERS.
        /// </summary>
        public const string M6VERS = "M6VERS";

        /// <summary>
        /// M6SQN.
        /// </summary>
        public const string M6SQN = "M6SQN";

        /// <summary>
        /// M6FLDN.
        /// </summary>
        public const string M6FLDN = "M6FLDN";

        /// <summary>
        /// M6FPID.
        /// </summary>
        public const string M6FPID = "M6FPID";

        /// <summary>
        /// M6BVER.
        /// </summary>
        public const string M6BVER = "M6BVER";

        /// <summary>
        /// M6VL01.
        /// </summary>
        public const string M6VL01 = "M6VL01";

        /// <summary>
        /// M6VL02.
        /// </summary>
        public const string M6VL02 = "M6VL02";

        /// <summary>
        /// M6VL03.
        /// </summary>
        public const string M6VL03 = "M6VL03";

        /// <summary>
        /// M6VL04.
        /// </summary>
        public const string M6VL04 = "M6VL04";

        /// <summary>
        /// M6VL05.
        /// </summary>
        public const string M6VL05 = "M6VL05";

        /// <summary>
        /// M6VL06.
        /// </summary>
        public const string M6VL06 = "M6VL06";

        /// <summary>
        /// M6VL07.
        /// </summary>
        public const string M6VL07 = "M6VL07";

        /// <summary>
        /// M6VL08.
        /// </summary>
        public const string M6VL08 = "M6VL08";

        /// <summary>
        /// M6VL09.
        /// </summary>
        public const string M6VL09 = "M6VL09";

        /// <summary>
        /// M6VL10.
        /// </summary>
        public const string M6VL10 = "M6VL10";

        /// <summary>
        /// M6VL11.
        /// </summary>
        public const string M6VL11 = "M6VL11";

        /// <summary>
        /// M6VL12.
        /// </summary>
        public const string M6VL12 = "M6VL12";

        /// <summary>
        /// M6VL13.
        /// </summary>
        public const string M6VL13 = "M6VL13";

        /// <summary>
        /// M6VL14.
        /// </summary>
        public const string M6VL14 = "M6VL14";

        /// <summary>
        /// M6VL15.
        /// </summary>
        public const string M6VL15 = "M6VL15";

        /// <summary>
        /// M6VL16.
        /// </summary>
        public const string M6VL16 = "M6VL16";

        /// <summary>
        /// M6VL17.
        /// </summary>
        public const string M6VL17 = "M6VL17";

        /// <summary>
        /// M6VL18.
        /// </summary>
        public const string M6VL18 = "M6VL18";

        /// <summary>
        /// M6VL19.
        /// </summary>
        public const string M6VL19 = "M6VL19";

        /// <summary>
        /// M6VL20.
        /// </summary>
        public const string M6VL20 = "M6VL20";

        /// <summary>
        /// M6VL21.
        /// </summary>
        public const string M6VL21 = "M6VL21";

        /// <summary>
        /// M6VL22.
        /// </summary>
        public const string M6VL22 = "M6VL22";

        /// <summary>
        /// M6VL23.
        /// </summary>
        public const string M6VL23 = "M6VL23";

        /// <summary>
        /// M6VL24.
        /// </summary>
        public const string M6VL24 = "M6VL24";

        /// <summary>
        /// M6VL25.
        /// </summary>
        public const string M6VL25 = "M6VL25";

        /// <summary>
        /// M6VL26.
        /// </summary>
        public const string M6VL26 = "M6VL26";

        /// <summary>
        /// M6VL27.
        /// </summary>
        public const string M6VL27 = "M6VL27";

        /// <summary>
        /// M6VL28.
        /// </summary>
        public const string M6VL28 = "M6VL28";

        /// <summary>
        /// M6VL29.
        /// </summary>
        public const string M6VL29 = "M6VL29";

        /// <summary>
        /// M6VL30.
        /// </summary>
        public const string M6VL30 = "M6VL30";

        /// <summary>
        /// M6VL31.
        /// </summary>
        public const string M6VL31 = "M6VL31";

        /// <summary>
        /// M6VL32.
        /// </summary>
        public const string M6VL32 = "M6VL32";

        /// <summary>
        /// M6VL33.
        /// </summary>
        public const string M6VL33 = "M6VL33";

        /// <summary>
        /// M6VL34.
        /// </summary>
        public const string M6VL34 = "M6VL34";

        /// <summary>
        /// M6VL35.
        /// </summary>
        public const string M6VL35 = "M6VL35";

        /// <summary>
        /// M6VL36.
        /// </summary>
        public const string M6VL36 = "M6VL36";

        /// <summary>
        /// M6VL37.
        /// </summary>
        public const string M6VL37 = "M6VL37";

        /// <summary>
        /// M6VL38.
        /// </summary>
        public const string M6VL38 = "M6VL38";

        /// <summary>
        /// M6VL39.
        /// </summary>
        public const string M6VL39 = "M6VL39";

        /// <summary>
        /// M6VL40.
        /// </summary>
        public const string M6VL40 = "M6VL40";

        /// <summary>
        /// M6VL41.
        /// </summary>
        public const string M6VL41 = "M6VL41";

        /// <summary>
        /// M6VL42.
        /// </summary>
        public const string M6VL42 = "M6VL42";

        /// <summary>
        /// M6VL43.
        /// </summary>
        public const string M6VL43 = "M6VL43";

        /// <summary>
        /// M6VL44.
        /// </summary>
        public const string M6VL44 = "M6VL44";

        /// <summary>
        /// M6VL45.
        /// </summary>
        public const string M6VL45 = "M6VL45";

        /// <summary>
        /// M6LUS.
        /// </summary>
        public const string M6LUS = "M6LUS";

        /// <summary>
        /// M6FPD.
        /// </summary>
        public const string M6FPD = "M6FPD";

        /// <summary>
        /// M6UPMJ.
        /// </summary>
        public const string M6UPMJ = "M6UPMJ";

        /// <summary>
        /// M6JOBN.
        /// </summary>
        public const string M6JOBN = "M6JOBN";

        /// <summary>
        /// M6UPMT.
        /// </summary>
        public const string M6UPMT = "M6UPMT";
    }

    /// <inheritdoc />
    public override string TableName => "F81A14";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("M6LDFR", "M6LDFR", JdeDataType.String, 20, true, true),
        new JdeField("M6PID", "M6PID", JdeDataType.String, 20, true, true),
        new JdeField("M6VERS", "M6VERS", JdeDataType.String, 20, true, true),
        new JdeField("M6SQN", "M6SQN", JdeDataType.Numeric, null, true, true),
        new JdeField("M6FLDN", "M6FLDN", JdeDataType.String, 12),
        new JdeField("M6FPID", "M6FPID", JdeDataType.String, 20),
        new JdeField("M6BVER", "M6BVER", JdeDataType.String, 20),
        new JdeField("M6VL01", "M6VL01", JdeDataType.String, 50),
        new JdeField("M6VL02", "M6VL02", JdeDataType.String, 50),
        new JdeField("M6VL03", "M6VL03", JdeDataType.String, 50),
        new JdeField("M6VL04", "M6VL04", JdeDataType.String, 50),
        new JdeField("M6VL05", "M6VL05", JdeDataType.String, 50),
        new JdeField("M6VL06", "M6VL06", JdeDataType.String, 50),
        new JdeField("M6VL07", "M6VL07", JdeDataType.String, 50),
        new JdeField("M6VL08", "M6VL08", JdeDataType.String, 50),
        new JdeField("M6VL09", "M6VL09", JdeDataType.String, 50),
        new JdeField("M6VL10", "M6VL10", JdeDataType.String, 50),
        new JdeField("M6VL11", "M6VL11", JdeDataType.String, 50),
        new JdeField("M6VL12", "M6VL12", JdeDataType.String, 50),
        new JdeField("M6VL13", "M6VL13", JdeDataType.String, 50),
        new JdeField("M6VL14", "M6VL14", JdeDataType.String, 50),
        new JdeField("M6VL15", "M6VL15", JdeDataType.String, 50),
        new JdeField("M6VL16", "M6VL16", JdeDataType.String, 50),
        new JdeField("M6VL17", "M6VL17", JdeDataType.String, 50),
        new JdeField("M6VL18", "M6VL18", JdeDataType.String, 50),
        new JdeField("M6VL19", "M6VL19", JdeDataType.String, 50),
        new JdeField("M6VL20", "M6VL20", JdeDataType.String, 50),
        new JdeField("M6VL21", "M6VL21", JdeDataType.String, 50),
        new JdeField("M6VL22", "M6VL22", JdeDataType.String, 50),
        new JdeField("M6VL23", "M6VL23", JdeDataType.String, 50),
        new JdeField("M6VL24", "M6VL24", JdeDataType.String, 50),
        new JdeField("M6VL25", "M6VL25", JdeDataType.String, 50),
        new JdeField("M6VL26", "M6VL26", JdeDataType.String, 50),
        new JdeField("M6VL27", "M6VL27", JdeDataType.String, 50),
        new JdeField("M6VL28", "M6VL28", JdeDataType.String, 50),
        new JdeField("M6VL29", "M6VL29", JdeDataType.String, 50),
        new JdeField("M6VL30", "M6VL30", JdeDataType.String, 50),
        new JdeField("M6VL31", "M6VL31", JdeDataType.String, 50),
        new JdeField("M6VL32", "M6VL32", JdeDataType.String, 50),
        new JdeField("M6VL33", "M6VL33", JdeDataType.String, 50),
        new JdeField("M6VL34", "M6VL34", JdeDataType.String, 50),
        new JdeField("M6VL35", "M6VL35", JdeDataType.String, 50),
        new JdeField("M6VL36", "M6VL36", JdeDataType.String, 50),
        new JdeField("M6VL37", "M6VL37", JdeDataType.String, 50),
        new JdeField("M6VL38", "M6VL38", JdeDataType.String, 50),
        new JdeField("M6VL39", "M6VL39", JdeDataType.String, 50),
        new JdeField("M6VL40", "M6VL40", JdeDataType.String, 50),
        new JdeField("M6VL41", "M6VL41", JdeDataType.String, 50),
        new JdeField("M6VL42", "M6VL42", JdeDataType.String, 50),
        new JdeField("M6VL43", "M6VL43", JdeDataType.String, 50),
        new JdeField("M6VL44", "M6VL44", JdeDataType.String, 50),
        new JdeField("M6VL45", "M6VL45", JdeDataType.String, 50),
        new JdeField("M6LUS", "M6LUS", JdeDataType.String, 20),
        new JdeField("M6FPD", "M6FPD", JdeDataType.String, 20),
        new JdeField("M6UPMJ", "M6UPMJ", JdeDataType.Numeric),
        new JdeField("M6JOBN", "M6JOBN", JdeDataType.String, 20),
        new JdeField("M6UPMT", "M6UPMT", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F81A14_0", "Primary Key on M6LDFR, M6PID, M6VERS, M6SQN", new[] { "M6LDFR", "M6PID", "M6VERS", "M6SQN" }, isUnique: true, isPrimaryKey: true)
    };
}
