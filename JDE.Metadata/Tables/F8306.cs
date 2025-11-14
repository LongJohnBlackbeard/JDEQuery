using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F8306 - .
/// </summary>
public class F8306 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// R6PID.
        /// </summary>
        public const string R6PID = "R6PID";

        /// <summary>
        /// R6VERS.
        /// </summary>
        public const string R6VERS = "R6VERS";

        /// <summary>
        /// R6RNBR.
        /// </summary>
        public const string R6RNBR = "R6RNBR";

        /// <summary>
        /// R6CNBR.
        /// </summary>
        public const string R6CNBR = "R6CNBR";

        /// <summary>
        /// R6DECI.
        /// </summary>
        public const string R6DECI = "R6DECI";

        /// <summary>
        /// R6RCLC.
        /// </summary>
        public const string R6RCLC = "R6RCLC";

        /// <summary>
        /// R6LT.
        /// </summary>
        public const string R6LT = "R6LT";

        /// <summary>
        /// R6CL01.
        /// </summary>
        public const string R6CL01 = "R6CL01";

        /// <summary>
        /// R6MO01.
        /// </summary>
        public const string R6MO01 = "R6MO01";

        /// <summary>
        /// R6CL02.
        /// </summary>
        public const string R6CL02 = "R6CL02";

        /// <summary>
        /// R6MO02.
        /// </summary>
        public const string R6MO02 = "R6MO02";

        /// <summary>
        /// R6CL03.
        /// </summary>
        public const string R6CL03 = "R6CL03";

        /// <summary>
        /// R6MO03.
        /// </summary>
        public const string R6MO03 = "R6MO03";

        /// <summary>
        /// R6CL04.
        /// </summary>
        public const string R6CL04 = "R6CL04";

        /// <summary>
        /// R6MO04.
        /// </summary>
        public const string R6MO04 = "R6MO04";

        /// <summary>
        /// R6CL05.
        /// </summary>
        public const string R6CL05 = "R6CL05";

        /// <summary>
        /// R6MO05.
        /// </summary>
        public const string R6MO05 = "R6MO05";

        /// <summary>
        /// R6CL06.
        /// </summary>
        public const string R6CL06 = "R6CL06";

        /// <summary>
        /// R6MO06.
        /// </summary>
        public const string R6MO06 = "R6MO06";

        /// <summary>
        /// R6CL07.
        /// </summary>
        public const string R6CL07 = "R6CL07";

        /// <summary>
        /// R6MO07.
        /// </summary>
        public const string R6MO07 = "R6MO07";

        /// <summary>
        /// R6CL08.
        /// </summary>
        public const string R6CL08 = "R6CL08";

        /// <summary>
        /// R6MO08.
        /// </summary>
        public const string R6MO08 = "R6MO08";

        /// <summary>
        /// R6CL09.
        /// </summary>
        public const string R6CL09 = "R6CL09";

        /// <summary>
        /// R6MO09.
        /// </summary>
        public const string R6MO09 = "R6MO09";

        /// <summary>
        /// R6CL10.
        /// </summary>
        public const string R6CL10 = "R6CL10";

        /// <summary>
        /// R6MO10.
        /// </summary>
        public const string R6MO10 = "R6MO10";

        /// <summary>
        /// R6CL11.
        /// </summary>
        public const string R6CL11 = "R6CL11";

        /// <summary>
        /// R6MO11.
        /// </summary>
        public const string R6MO11 = "R6MO11";

        /// <summary>
        /// R6CL12.
        /// </summary>
        public const string R6CL12 = "R6CL12";

        /// <summary>
        /// R6MO12.
        /// </summary>
        public const string R6MO12 = "R6MO12";

        /// <summary>
        /// R6CL13.
        /// </summary>
        public const string R6CL13 = "R6CL13";

        /// <summary>
        /// R6MO13.
        /// </summary>
        public const string R6MO13 = "R6MO13";

        /// <summary>
        /// R6CL14.
        /// </summary>
        public const string R6CL14 = "R6CL14";

        /// <summary>
        /// R6MO14.
        /// </summary>
        public const string R6MO14 = "R6MO14";

        /// <summary>
        /// R6CL15.
        /// </summary>
        public const string R6CL15 = "R6CL15";

        /// <summary>
        /// R6MO15.
        /// </summary>
        public const string R6MO15 = "R6MO15";

        /// <summary>
        /// R6CL16.
        /// </summary>
        public const string R6CL16 = "R6CL16";

        /// <summary>
        /// R6MO16.
        /// </summary>
        public const string R6MO16 = "R6MO16";

        /// <summary>
        /// R6CL17.
        /// </summary>
        public const string R6CL17 = "R6CL17";

        /// <summary>
        /// R6MO17.
        /// </summary>
        public const string R6MO17 = "R6MO17";

        /// <summary>
        /// R6CL18.
        /// </summary>
        public const string R6CL18 = "R6CL18";

        /// <summary>
        /// R6MO18.
        /// </summary>
        public const string R6MO18 = "R6MO18";

        /// <summary>
        /// R6CL19.
        /// </summary>
        public const string R6CL19 = "R6CL19";

        /// <summary>
        /// R6MO19.
        /// </summary>
        public const string R6MO19 = "R6MO19";

        /// <summary>
        /// R6CL20.
        /// </summary>
        public const string R6CL20 = "R6CL20";

        /// <summary>
        /// R6MO20.
        /// </summary>
        public const string R6MO20 = "R6MO20";
    }

    /// <inheritdoc />
    public override string TableName => "F8306";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("R6PID", "R6PID", JdeDataType.String, 20, true, true),
        new JdeField("R6VERS", "R6VERS", JdeDataType.String, 20, true, true),
        new JdeField("R6RNBR", "R6RNBR", JdeDataType.String, 8, true, true),
        new JdeField("R6CNBR", "R6CNBR", JdeDataType.String, 4, true, true),
        new JdeField("R6DECI", "R6DECI", JdeDataType.String, 2),
        new JdeField("R6RCLC", "R6RCLC", JdeDataType.String, 2),
        new JdeField("R6LT", "R6LT", JdeDataType.String, 4),
        new JdeField("R6CL01", "R6CL01", JdeDataType.String, 20),
        new JdeField("R6MO01", "R6MO01", JdeDataType.String, 2),
        new JdeField("R6CL02", "R6CL02", JdeDataType.String, 20),
        new JdeField("R6MO02", "R6MO02", JdeDataType.String, 2),
        new JdeField("R6CL03", "R6CL03", JdeDataType.String, 20),
        new JdeField("R6MO03", "R6MO03", JdeDataType.String, 2),
        new JdeField("R6CL04", "R6CL04", JdeDataType.String, 20),
        new JdeField("R6MO04", "R6MO04", JdeDataType.String, 2),
        new JdeField("R6CL05", "R6CL05", JdeDataType.String, 20),
        new JdeField("R6MO05", "R6MO05", JdeDataType.String, 2),
        new JdeField("R6CL06", "R6CL06", JdeDataType.String, 20),
        new JdeField("R6MO06", "R6MO06", JdeDataType.String, 2),
        new JdeField("R6CL07", "R6CL07", JdeDataType.String, 20),
        new JdeField("R6MO07", "R6MO07", JdeDataType.String, 2),
        new JdeField("R6CL08", "R6CL08", JdeDataType.String, 20),
        new JdeField("R6MO08", "R6MO08", JdeDataType.String, 2),
        new JdeField("R6CL09", "R6CL09", JdeDataType.String, 20),
        new JdeField("R6MO09", "R6MO09", JdeDataType.String, 2),
        new JdeField("R6CL10", "R6CL10", JdeDataType.String, 20),
        new JdeField("R6MO10", "R6MO10", JdeDataType.String, 2),
        new JdeField("R6CL11", "R6CL11", JdeDataType.String, 20),
        new JdeField("R6MO11", "R6MO11", JdeDataType.String, 2),
        new JdeField("R6CL12", "R6CL12", JdeDataType.String, 20),
        new JdeField("R6MO12", "R6MO12", JdeDataType.String, 2),
        new JdeField("R6CL13", "R6CL13", JdeDataType.String, 20),
        new JdeField("R6MO13", "R6MO13", JdeDataType.String, 2),
        new JdeField("R6CL14", "R6CL14", JdeDataType.String, 20),
        new JdeField("R6MO14", "R6MO14", JdeDataType.String, 2),
        new JdeField("R6CL15", "R6CL15", JdeDataType.String, 20),
        new JdeField("R6MO15", "R6MO15", JdeDataType.String, 2),
        new JdeField("R6CL16", "R6CL16", JdeDataType.String, 20),
        new JdeField("R6MO16", "R6MO16", JdeDataType.String, 2),
        new JdeField("R6CL17", "R6CL17", JdeDataType.String, 20),
        new JdeField("R6MO17", "R6MO17", JdeDataType.String, 2),
        new JdeField("R6CL18", "R6CL18", JdeDataType.String, 20),
        new JdeField("R6MO18", "R6MO18", JdeDataType.String, 2),
        new JdeField("R6CL19", "R6CL19", JdeDataType.String, 20),
        new JdeField("R6MO19", "R6MO19", JdeDataType.String, 2),
        new JdeField("R6CL20", "R6CL20", JdeDataType.String, 20),
        new JdeField("R6MO20", "R6MO20", JdeDataType.String, 2)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F8306_0", "Primary Key on R6PID, R6VERS, R6RNBR, R6CNBR", new[] { "R6PID", "R6VERS", "R6RNBR", "R6CNBR" }, isUnique: true, isPrimaryKey: true)
    };
}
