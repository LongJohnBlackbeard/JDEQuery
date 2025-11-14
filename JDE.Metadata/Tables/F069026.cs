using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F069026 - .
/// </summary>
public class F069026 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// Y2FTC.
        /// </summary>
        public const string Y2FTC = "Y2FTC";

        /// <summary>
        /// Y2LCL.
        /// </summary>
        public const string Y2LCL = "Y2LCL";

        /// <summary>
        /// Y2UCL.
        /// </summary>
        public const string Y2UCL = "Y2UCL";

        /// <summary>
        /// Y2PRUM.
        /// </summary>
        public const string Y2PRUM = "Y2PRUM";

        /// <summary>
        /// Y2FT2.
        /// </summary>
        public const string Y2FT2 = "Y2FT2";

        /// <summary>
        /// Y2FT3.
        /// </summary>
        public const string Y2FT3 = "Y2FT3";

        /// <summary>
        /// Y2FT4.
        /// </summary>
        public const string Y2FT4 = "Y2FT4";

        /// <summary>
        /// Y2PID.
        /// </summary>
        public const string Y2PID = "Y2PID";

        /// <summary>
        /// Y2USER.
        /// </summary>
        public const string Y2USER = "Y2USER";

        /// <summary>
        /// Y2UPMJ.
        /// </summary>
        public const string Y2UPMJ = "Y2UPMJ";

        /// <summary>
        /// Y2DC.
        /// </summary>
        public const string Y2DC = "Y2DC";

        /// <summary>
        /// Y2EXA.
        /// </summary>
        public const string Y2EXA = "Y2EXA";

        /// <summary>
        /// Y2DL01.
        /// </summary>
        public const string Y2DL01 = "Y2DL01";

        /// <summary>
        /// Y2DL02.
        /// </summary>
        public const string Y2DL02 = "Y2DL02";

        /// <summary>
        /// Y2DL03.
        /// </summary>
        public const string Y2DL03 = "Y2DL03";

        /// <summary>
        /// Y2DL04.
        /// </summary>
        public const string Y2DL04 = "Y2DL04";

        /// <summary>
        /// Y2DL05.
        /// </summary>
        public const string Y2DL05 = "Y2DL05";

        /// <summary>
        /// Y2EXRT.
        /// </summary>
        public const string Y2EXRT = "Y2EXRT";

        /// <summary>
        /// Y2ADL.
        /// </summary>
        public const string Y2ADL = "Y2ADL";

        /// <summary>
        /// Y2TABT.
        /// </summary>
        public const string Y2TABT = "Y2TABT";

        /// <summary>
        /// Y2STAB.
        /// </summary>
        public const string Y2STAB = "Y2STAB";

        /// <summary>
        /// Y2CMAX.
        /// </summary>
        public const string Y2CMAX = "Y2CMAX";

        /// <summary>
        /// Y2DEDS.
        /// </summary>
        public const string Y2DEDS = "Y2DEDS";
    }

    /// <inheritdoc />
    public override string TableName => "F069026";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("Y2FTC", "Y2FTC", JdeDataType.String, 10, true, true),
        new JdeField("Y2LCL", "Y2LCL", JdeDataType.Numeric),
        new JdeField("Y2UCL", "Y2UCL", JdeDataType.Numeric, null, true, true),
        new JdeField("Y2PRUM", "Y2PRUM", JdeDataType.String, 4),
        new JdeField("Y2FT2", "Y2FT2", JdeDataType.Numeric),
        new JdeField("Y2FT3", "Y2FT3", JdeDataType.Numeric),
        new JdeField("Y2FT4", "Y2FT4", JdeDataType.Numeric),
        new JdeField("Y2PID", "Y2PID", JdeDataType.String, 20),
        new JdeField("Y2USER", "Y2USER", JdeDataType.String, 20),
        new JdeField("Y2UPMJ", "Y2UPMJ", JdeDataType.Numeric),
        new JdeField("Y2DC", "Y2DC", JdeDataType.String, 80),
        new JdeField("Y2EXA", "Y2EXA", JdeDataType.String, 60),
        new JdeField("Y2DL01", "Y2DL01", JdeDataType.String, 60),
        new JdeField("Y2DL02", "Y2DL02", JdeDataType.String, 60),
        new JdeField("Y2DL03", "Y2DL03", JdeDataType.String, 60),
        new JdeField("Y2DL04", "Y2DL04", JdeDataType.String, 60),
        new JdeField("Y2DL05", "Y2DL05", JdeDataType.String, 60),
        new JdeField("Y2EXRT", "Y2EXRT", JdeDataType.Numeric),
        new JdeField("Y2ADL", "Y2ADL", JdeDataType.Numeric),
        new JdeField("Y2TABT", "Y2TABT", JdeDataType.String, 2, true, true),
        new JdeField("Y2STAB", "Y2STAB", JdeDataType.String, 10),
        new JdeField("Y2CMAX", "Y2CMAX", JdeDataType.Numeric),
        new JdeField("Y2DEDS", "Y2DEDS", JdeDataType.String, 2)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F069026_0", "Primary Key on Y2TABT, Y2FTC, Y2UCL", new[] { "Y2TABT", "Y2FTC", "Y2UCL" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F069026_2", "Index on Y2TABT, Y2DC", new[] { "Y2TABT", "Y2DC" }),
        new JdeIndex("F069026_3", "Index on Y2TABT, Y2FTC", new[] { "Y2TABT", "Y2FTC" })
    };
}
