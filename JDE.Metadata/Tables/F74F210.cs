using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F74F210 - .
/// </summary>
public class F74F210 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// FPFY.
        /// </summary>
        public const string FPFY = "FPFY";

        /// <summary>
        /// FPCO.
        /// </summary>
        public const string FPCO = "FPCO";

        /// <summary>
        /// FPICUT.
        /// </summary>
        public const string FPICUT = "FPICUT";

        /// <summary>
        /// FPPN.
        /// </summary>
        public const string FPPN = "FPPN";

        /// <summary>
        /// FPF74FECLS.
        /// </summary>
        public const string FPF74FECLS = "FPF74FECLS";

        /// <summary>
        /// FPMUPM.
        /// </summary>
        public const string FPMUPM = "FPMUPM";

        /// <summary>
        /// FPF74FTD.
        /// </summary>
        public const string FPF74FTD = "FPF74FTD";

        /// <summary>
        /// FPF74FTC.
        /// </summary>
        public const string FPF74FTC = "FPF74FTC";

        /// <summary>
        /// FPCRCD.
        /// </summary>
        public const string FPCRCD = "FPCRCD";

        /// <summary>
        /// FPUSER.
        /// </summary>
        public const string FPUSER = "FPUSER";

        /// <summary>
        /// FPPID.
        /// </summary>
        public const string FPPID = "FPPID";

        /// <summary>
        /// FPUPMJ.
        /// </summary>
        public const string FPUPMJ = "FPUPMJ";

        /// <summary>
        /// FPUPMT.
        /// </summary>
        public const string FPUPMT = "FPUPMT";

        /// <summary>
        /// FPJOBN.
        /// </summary>
        public const string FPJOBN = "FPJOBN";
    }

    /// <inheritdoc />
    public override string TableName => "F74F210";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("FPFY", "FPFY", JdeDataType.Numeric, null, true, true),
        new JdeField("FPCO", "FPCO", JdeDataType.String, 10, true, true),
        new JdeField("FPICUT", "FPICUT", JdeDataType.String, 4, true, true),
        new JdeField("FPPN", "FPPN", JdeDataType.Numeric, null, true, true),
        new JdeField("FPF74FECLS", "FPF74FECLS", JdeDataType.Numeric),
        new JdeField("FPMUPM", "FPMUPM", JdeDataType.Numeric),
        new JdeField("FPF74FTD", "FPF74FTD", JdeDataType.Numeric),
        new JdeField("FPF74FTC", "FPF74FTC", JdeDataType.Numeric),
        new JdeField("FPCRCD", "FPCRCD", JdeDataType.String, 6),
        new JdeField("FPUSER", "FPUSER", JdeDataType.String, 20),
        new JdeField("FPPID", "FPPID", JdeDataType.String, 20),
        new JdeField("FPUPMJ", "FPUPMJ", JdeDataType.Numeric),
        new JdeField("FPUPMT", "FPUPMT", JdeDataType.Numeric),
        new JdeField("FPJOBN", "FPJOBN", JdeDataType.String, 20)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F74F210_0", "Primary Key on FPFY, FPCO, FPICUT, FPPN", new[] { "FPFY", "FPCO", "FPICUT", "FPPN" }, isUnique: true, isPrimaryKey: true)
    };
}
