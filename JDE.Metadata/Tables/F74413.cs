using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F74413 - .
/// </summary>
public class F74413 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// VCCO.
        /// </summary>
        public const string VCCO = "VCCO";

        /// <summary>
        /// VCDFYJ.
        /// </summary>
        public const string VCDFYJ = "VCDFYJ";

        /// <summary>
        /// VCFY.
        /// </summary>
        public const string VCFY = "VCFY";

        /// <summary>
        /// VCVCIA.
        /// </summary>
        public const string VCVCIA = "VCVCIA";

        /// <summary>
        /// VCAN01.
        /// </summary>
        public const string VCAN01 = "VCAN01";

        /// <summary>
        /// VCAN02.
        /// </summary>
        public const string VCAN02 = "VCAN02";

        /// <summary>
        /// VCAN03.
        /// </summary>
        public const string VCAN03 = "VCAN03";

        /// <summary>
        /// VCAN04.
        /// </summary>
        public const string VCAN04 = "VCAN04";

        /// <summary>
        /// VCAN05.
        /// </summary>
        public const string VCAN05 = "VCAN05";

        /// <summary>
        /// VCAN06.
        /// </summary>
        public const string VCAN06 = "VCAN06";

        /// <summary>
        /// VCAN07.
        /// </summary>
        public const string VCAN07 = "VCAN07";

        /// <summary>
        /// VCAN08.
        /// </summary>
        public const string VCAN08 = "VCAN08";

        /// <summary>
        /// VCAN09.
        /// </summary>
        public const string VCAN09 = "VCAN09";

        /// <summary>
        /// VCAN10.
        /// </summary>
        public const string VCAN10 = "VCAN10";

        /// <summary>
        /// VCAN11.
        /// </summary>
        public const string VCAN11 = "VCAN11";

        /// <summary>
        /// VCAN12.
        /// </summary>
        public const string VCAN12 = "VCAN12";

        /// <summary>
        /// VCAN13.
        /// </summary>
        public const string VCAN13 = "VCAN13";

        /// <summary>
        /// VCAN14.
        /// </summary>
        public const string VCAN14 = "VCAN14";

        /// <summary>
        /// VCAN8.
        /// </summary>
        public const string VCAN8 = "VCAN8";

        /// <summary>
        /// VCVCTR.
        /// </summary>
        public const string VCVCTR = "VCVCTR";

        /// <summary>
        /// VCUSER.
        /// </summary>
        public const string VCUSER = "VCUSER";

        /// <summary>
        /// VCPID.
        /// </summary>
        public const string VCPID = "VCPID";

        /// <summary>
        /// VCUPMJ.
        /// </summary>
        public const string VCUPMJ = "VCUPMJ";

        /// <summary>
        /// VCJOBN.
        /// </summary>
        public const string VCJOBN = "VCJOBN";

        /// <summary>
        /// VCUPMT.
        /// </summary>
        public const string VCUPMT = "VCUPMT";
    }

    /// <inheritdoc />
    public override string TableName => "F74413";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("VCCO", "VCCO", JdeDataType.String, 10, true, true),
        new JdeField("VCDFYJ", "VCDFYJ", JdeDataType.Numeric, null, true, true),
        new JdeField("VCFY", "VCFY", JdeDataType.Numeric),
        new JdeField("VCVCIA", "VCVCIA", JdeDataType.Numeric),
        new JdeField("VCAN01", "VCAN01", JdeDataType.Numeric),
        new JdeField("VCAN02", "VCAN02", JdeDataType.Numeric),
        new JdeField("VCAN03", "VCAN03", JdeDataType.Numeric),
        new JdeField("VCAN04", "VCAN04", JdeDataType.Numeric),
        new JdeField("VCAN05", "VCAN05", JdeDataType.Numeric),
        new JdeField("VCAN06", "VCAN06", JdeDataType.Numeric),
        new JdeField("VCAN07", "VCAN07", JdeDataType.Numeric),
        new JdeField("VCAN08", "VCAN08", JdeDataType.Numeric),
        new JdeField("VCAN09", "VCAN09", JdeDataType.Numeric),
        new JdeField("VCAN10", "VCAN10", JdeDataType.Numeric),
        new JdeField("VCAN11", "VCAN11", JdeDataType.Numeric),
        new JdeField("VCAN12", "VCAN12", JdeDataType.Numeric),
        new JdeField("VCAN13", "VCAN13", JdeDataType.Numeric),
        new JdeField("VCAN14", "VCAN14", JdeDataType.Numeric),
        new JdeField("VCAN8", "VCAN8", JdeDataType.Numeric),
        new JdeField("VCVCTR", "VCVCTR", JdeDataType.Numeric),
        new JdeField("VCUSER", "VCUSER", JdeDataType.String, 20),
        new JdeField("VCPID", "VCPID", JdeDataType.String, 20),
        new JdeField("VCUPMJ", "VCUPMJ", JdeDataType.Numeric),
        new JdeField("VCJOBN", "VCJOBN", JdeDataType.String, 20),
        new JdeField("VCUPMT", "VCUPMT", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F74413_0", "Primary Key on VCCO, VCDFYJ", new[] { "VCCO", "VCDFYJ" }, isUnique: true, isPrimaryKey: true)
    };
}
