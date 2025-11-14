using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F34A40 - .
/// </summary>
public class F34A40 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// N0SY.
        /// </summary>
        public const string N0SY = "N0SY";

        /// <summary>
        /// N0MMCU.
        /// </summary>
        public const string N0MMCU = "N0MMCU";

        /// <summary>
        /// N0SRP1.
        /// </summary>
        public const string N0SRP1 = "N0SRP1";

        /// <summary>
        /// N0SRP2.
        /// </summary>
        public const string N0SRP2 = "N0SRP2";

        /// <summary>
        /// N0SRP3.
        /// </summary>
        public const string N0SRP3 = "N0SRP3";

        /// <summary>
        /// N0SRP4.
        /// </summary>
        public const string N0SRP4 = "N0SRP4";

        /// <summary>
        /// N0SRP5.
        /// </summary>
        public const string N0SRP5 = "N0SRP5";

        /// <summary>
        /// N0SRP6.
        /// </summary>
        public const string N0SRP6 = "N0SRP6";

        /// <summary>
        /// N0SRP7.
        /// </summary>
        public const string N0SRP7 = "N0SRP7";

        /// <summary>
        /// N0SRP8.
        /// </summary>
        public const string N0SRP8 = "N0SRP8";

        /// <summary>
        /// N0SRP9.
        /// </summary>
        public const string N0SRP9 = "N0SRP9";

        /// <summary>
        /// N0SRP0.
        /// </summary>
        public const string N0SRP0 = "N0SRP0";

        /// <summary>
        /// N0PRP1.
        /// </summary>
        public const string N0PRP1 = "N0PRP1";

        /// <summary>
        /// N0PRP2.
        /// </summary>
        public const string N0PRP2 = "N0PRP2";

        /// <summary>
        /// N0PRP3.
        /// </summary>
        public const string N0PRP3 = "N0PRP3";

        /// <summary>
        /// N0PRP4.
        /// </summary>
        public const string N0PRP4 = "N0PRP4";

        /// <summary>
        /// N0PRP5.
        /// </summary>
        public const string N0PRP5 = "N0PRP5";

        /// <summary>
        /// N0PRP6.
        /// </summary>
        public const string N0PRP6 = "N0PRP6";

        /// <summary>
        /// N0PRP7.
        /// </summary>
        public const string N0PRP7 = "N0PRP7";

        /// <summary>
        /// N0PRP8.
        /// </summary>
        public const string N0PRP8 = "N0PRP8";

        /// <summary>
        /// N0PRP9.
        /// </summary>
        public const string N0PRP9 = "N0PRP9";

        /// <summary>
        /// N0PRP0.
        /// </summary>
        public const string N0PRP0 = "N0PRP0";

        /// <summary>
        /// N0CARP.
        /// </summary>
        public const string N0CARP = "N0CARP";

        /// <summary>
        /// N0CARS.
        /// </summary>
        public const string N0CARS = "N0CARS";

        /// <summary>
        /// N0SHCN.
        /// </summary>
        public const string N0SHCN = "N0SHCN";

        /// <summary>
        /// N0SHCM.
        /// </summary>
        public const string N0SHCM = "N0SHCM";

        /// <summary>
        /// N0CYCL.
        /// </summary>
        public const string N0CYCL = "N0CYCL";

        /// <summary>
        /// N0RP01.
        /// </summary>
        public const string N0RP01 = "N0RP01";

        /// <summary>
        /// N0RP02.
        /// </summary>
        public const string N0RP02 = "N0RP02";

        /// <summary>
        /// N0RP03.
        /// </summary>
        public const string N0RP03 = "N0RP03";

        /// <summary>
        /// N0RP04.
        /// </summary>
        public const string N0RP04 = "N0RP04";

        /// <summary>
        /// N0RP05.
        /// </summary>
        public const string N0RP05 = "N0RP05";

        /// <summary>
        /// N0RP06.
        /// </summary>
        public const string N0RP06 = "N0RP06";

        /// <summary>
        /// N0RP07.
        /// </summary>
        public const string N0RP07 = "N0RP07";

        /// <summary>
        /// N0RP08.
        /// </summary>
        public const string N0RP08 = "N0RP08";

        /// <summary>
        /// N0RP09.
        /// </summary>
        public const string N0RP09 = "N0RP09";

        /// <summary>
        /// N0RP10.
        /// </summary>
        public const string N0RP10 = "N0RP10";

        /// <summary>
        /// N0RP11.
        /// </summary>
        public const string N0RP11 = "N0RP11";

        /// <summary>
        /// N0RP12.
        /// </summary>
        public const string N0RP12 = "N0RP12";

        /// <summary>
        /// N0RP13.
        /// </summary>
        public const string N0RP13 = "N0RP13";

        /// <summary>
        /// N0RP14.
        /// </summary>
        public const string N0RP14 = "N0RP14";

        /// <summary>
        /// N0RP15.
        /// </summary>
        public const string N0RP15 = "N0RP15";

        /// <summary>
        /// N0RP16.
        /// </summary>
        public const string N0RP16 = "N0RP16";

        /// <summary>
        /// N0RP17.
        /// </summary>
        public const string N0RP17 = "N0RP17";

        /// <summary>
        /// N0RP18.
        /// </summary>
        public const string N0RP18 = "N0RP18";

        /// <summary>
        /// N0RP19.
        /// </summary>
        public const string N0RP19 = "N0RP19";

        /// <summary>
        /// N0RP20.
        /// </summary>
        public const string N0RP20 = "N0RP20";

        /// <summary>
        /// N0RP21.
        /// </summary>
        public const string N0RP21 = "N0RP21";

        /// <summary>
        /// N0RP22.
        /// </summary>
        public const string N0RP22 = "N0RP22";

        /// <summary>
        /// N0RP23.
        /// </summary>
        public const string N0RP23 = "N0RP23";

        /// <summary>
        /// N0RP24.
        /// </summary>
        public const string N0RP24 = "N0RP24";

        /// <summary>
        /// N0RP25.
        /// </summary>
        public const string N0RP25 = "N0RP25";

        /// <summary>
        /// N0RP26.
        /// </summary>
        public const string N0RP26 = "N0RP26";

        /// <summary>
        /// N0RP27.
        /// </summary>
        public const string N0RP27 = "N0RP27";

        /// <summary>
        /// N0RP28.
        /// </summary>
        public const string N0RP28 = "N0RP28";

        /// <summary>
        /// N0RP29.
        /// </summary>
        public const string N0RP29 = "N0RP29";

        /// <summary>
        /// N0RP30.
        /// </summary>
        public const string N0RP30 = "N0RP30";

        /// <summary>
        /// N0USER.
        /// </summary>
        public const string N0USER = "N0USER";

        /// <summary>
        /// N0PID.
        /// </summary>
        public const string N0PID = "N0PID";

        /// <summary>
        /// N0JOBN.
        /// </summary>
        public const string N0JOBN = "N0JOBN";

        /// <summary>
        /// N0UPMJ.
        /// </summary>
        public const string N0UPMJ = "N0UPMJ";

        /// <summary>
        /// N0TICU.
        /// </summary>
        public const string N0TICU = "N0TICU";
    }

    /// <inheritdoc />
    public override string TableName => "F34A40";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("N0SY", "N0SY", JdeDataType.String, 8, true, true),
        new JdeField("N0MMCU", "N0MMCU", JdeDataType.String, 24, true, true),
        new JdeField("N0SRP1", "N0SRP1", JdeDataType.String, 6),
        new JdeField("N0SRP2", "N0SRP2", JdeDataType.String, 6),
        new JdeField("N0SRP3", "N0SRP3", JdeDataType.String, 6),
        new JdeField("N0SRP4", "N0SRP4", JdeDataType.String, 6),
        new JdeField("N0SRP5", "N0SRP5", JdeDataType.String, 6),
        new JdeField("N0SRP6", "N0SRP6", JdeDataType.String, 12),
        new JdeField("N0SRP7", "N0SRP7", JdeDataType.String, 12),
        new JdeField("N0SRP8", "N0SRP8", JdeDataType.String, 12),
        new JdeField("N0SRP9", "N0SRP9", JdeDataType.String, 12),
        new JdeField("N0SRP0", "N0SRP0", JdeDataType.String, 12),
        new JdeField("N0PRP1", "N0PRP1", JdeDataType.String, 6),
        new JdeField("N0PRP2", "N0PRP2", JdeDataType.String, 6),
        new JdeField("N0PRP3", "N0PRP3", JdeDataType.String, 6),
        new JdeField("N0PRP4", "N0PRP4", JdeDataType.String, 6),
        new JdeField("N0PRP5", "N0PRP5", JdeDataType.String, 6),
        new JdeField("N0PRP6", "N0PRP6", JdeDataType.String, 12),
        new JdeField("N0PRP7", "N0PRP7", JdeDataType.String, 12),
        new JdeField("N0PRP8", "N0PRP8", JdeDataType.String, 12),
        new JdeField("N0PRP9", "N0PRP9", JdeDataType.String, 12),
        new JdeField("N0PRP0", "N0PRP0", JdeDataType.String, 12),
        new JdeField("N0CARP", "N0CARP", JdeDataType.Numeric),
        new JdeField("N0CARS", "N0CARS", JdeDataType.Numeric),
        new JdeField("N0SHCN", "N0SHCN", JdeDataType.String, 6),
        new JdeField("N0SHCM", "N0SHCM", JdeDataType.String, 6),
        new JdeField("N0CYCL", "N0CYCL", JdeDataType.String, 6),
        new JdeField("N0RP01", "N0RP01", JdeDataType.String, 6),
        new JdeField("N0RP02", "N0RP02", JdeDataType.String, 6),
        new JdeField("N0RP03", "N0RP03", JdeDataType.String, 6),
        new JdeField("N0RP04", "N0RP04", JdeDataType.String, 6),
        new JdeField("N0RP05", "N0RP05", JdeDataType.String, 6),
        new JdeField("N0RP06", "N0RP06", JdeDataType.String, 6),
        new JdeField("N0RP07", "N0RP07", JdeDataType.String, 6),
        new JdeField("N0RP08", "N0RP08", JdeDataType.String, 6),
        new JdeField("N0RP09", "N0RP09", JdeDataType.String, 6),
        new JdeField("N0RP10", "N0RP10", JdeDataType.String, 6),
        new JdeField("N0RP11", "N0RP11", JdeDataType.String, 6),
        new JdeField("N0RP12", "N0RP12", JdeDataType.String, 6),
        new JdeField("N0RP13", "N0RP13", JdeDataType.String, 6),
        new JdeField("N0RP14", "N0RP14", JdeDataType.String, 6),
        new JdeField("N0RP15", "N0RP15", JdeDataType.String, 6),
        new JdeField("N0RP16", "N0RP16", JdeDataType.String, 6),
        new JdeField("N0RP17", "N0RP17", JdeDataType.String, 6),
        new JdeField("N0RP18", "N0RP18", JdeDataType.String, 6),
        new JdeField("N0RP19", "N0RP19", JdeDataType.String, 6),
        new JdeField("N0RP20", "N0RP20", JdeDataType.String, 6),
        new JdeField("N0RP21", "N0RP21", JdeDataType.String, 20),
        new JdeField("N0RP22", "N0RP22", JdeDataType.String, 20),
        new JdeField("N0RP23", "N0RP23", JdeDataType.String, 20),
        new JdeField("N0RP24", "N0RP24", JdeDataType.String, 20),
        new JdeField("N0RP25", "N0RP25", JdeDataType.String, 20),
        new JdeField("N0RP26", "N0RP26", JdeDataType.String, 20),
        new JdeField("N0RP27", "N0RP27", JdeDataType.String, 20),
        new JdeField("N0RP28", "N0RP28", JdeDataType.String, 20),
        new JdeField("N0RP29", "N0RP29", JdeDataType.String, 20),
        new JdeField("N0RP30", "N0RP30", JdeDataType.String, 20),
        new JdeField("N0USER", "N0USER", JdeDataType.String, 20),
        new JdeField("N0PID", "N0PID", JdeDataType.String, 20),
        new JdeField("N0JOBN", "N0JOBN", JdeDataType.String, 20),
        new JdeField("N0UPMJ", "N0UPMJ", JdeDataType.Numeric),
        new JdeField("N0TICU", "N0TICU", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F34A40_0", "Primary Key on N0SY, N0MMCU", new[] { "N0SY", "N0MMCU" }, isUnique: true, isPrimaryKey: true)
    };
}
