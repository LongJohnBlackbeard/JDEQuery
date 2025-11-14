using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F703B102 - .
/// </summary>
public class F703B102 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// RPPYID.
        /// </summary>
        public const string RPPYID = "RPPYID";

        /// <summary>
        /// RPICUT.
        /// </summary>
        public const string RPICUT = "RPICUT";

        /// <summary>
        /// RPICU.
        /// </summary>
        public const string RPICU = "RPICU";

        /// <summary>
        /// RPCO.
        /// </summary>
        public const string RPCO = "RPCO";

        /// <summary>
        /// RPK70IT.
        /// </summary>
        public const string RPK70IT = "RPK70IT";

        /// <summary>
        /// RPK70SER.
        /// </summary>
        public const string RPK70SER = "RPK70SER";

        /// <summary>
        /// RPK70ENUM.
        /// </summary>
        public const string RPK70ENUM = "RPK70ENUM";

        /// <summary>
        /// RPUSER.
        /// </summary>
        public const string RPUSER = "RPUSER";

        /// <summary>
        /// RPPID.
        /// </summary>
        public const string RPPID = "RPPID";

        /// <summary>
        /// RPJOBN.
        /// </summary>
        public const string RPJOBN = "RPJOBN";

        /// <summary>
        /// RPUPMJ.
        /// </summary>
        public const string RPUPMJ = "RPUPMJ";

        /// <summary>
        /// RPTDAY.
        /// </summary>
        public const string RPTDAY = "RPTDAY";
    }

    /// <inheritdoc />
    public override string TableName => "F703B102";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("RPPYID", "RPPYID", JdeDataType.Numeric, null, true, true),
        new JdeField("RPICUT", "RPICUT", JdeDataType.String, 4, true, true),
        new JdeField("RPICU", "RPICU", JdeDataType.Numeric, null, true, true),
        new JdeField("RPCO", "RPCO", JdeDataType.String, 10, true, true),
        new JdeField("RPK70IT", "RPK70IT", JdeDataType.String, 4),
        new JdeField("RPK70SER", "RPK70SER", JdeDataType.String, 40),
        new JdeField("RPK70ENUM", "RPK70ENUM", JdeDataType.String, 72),
        new JdeField("RPUSER", "RPUSER", JdeDataType.String, 20),
        new JdeField("RPPID", "RPPID", JdeDataType.String, 20),
        new JdeField("RPJOBN", "RPJOBN", JdeDataType.String, 20),
        new JdeField("RPUPMJ", "RPUPMJ", JdeDataType.Numeric),
        new JdeField("RPTDAY", "RPTDAY", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F703B102_0", "Primary Key on RPPYID, RPICUT, RPICU, RPCO", new[] { "RPPYID", "RPICUT", "RPICU", "RPCO" }, isUnique: true, isPrimaryKey: true)
    };
}
