using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F703B1Z1 - .
/// </summary>
public class F703B1Z1 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// AZEDUS.
        /// </summary>
        public const string AZEDUS = "AZEDUS";

        /// <summary>
        /// AZEDTN.
        /// </summary>
        public const string AZEDTN = "AZEDTN";

        /// <summary>
        /// AZEDBT.
        /// </summary>
        public const string AZEDBT = "AZEDBT";

        /// <summary>
        /// AZK70IT.
        /// </summary>
        public const string AZK70IT = "AZK70IT";

        /// <summary>
        /// AZK70SER.
        /// </summary>
        public const string AZK70SER = "AZK70SER";

        /// <summary>
        /// AZK70ENUM.
        /// </summary>
        public const string AZK70ENUM = "AZK70ENUM";

        /// <summary>
        /// AZUSER.
        /// </summary>
        public const string AZUSER = "AZUSER";

        /// <summary>
        /// AZPID.
        /// </summary>
        public const string AZPID = "AZPID";

        /// <summary>
        /// AZJOBN.
        /// </summary>
        public const string AZJOBN = "AZJOBN";

        /// <summary>
        /// AZUPMJ.
        /// </summary>
        public const string AZUPMJ = "AZUPMJ";

        /// <summary>
        /// AZTDAY.
        /// </summary>
        public const string AZTDAY = "AZTDAY";
    }

    /// <inheritdoc />
    public override string TableName => "F703B1Z1";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("AZEDUS", "AZEDUS", JdeDataType.String, 20, true, true),
        new JdeField("AZEDTN", "AZEDTN", JdeDataType.String, 44, true, true),
        new JdeField("AZEDBT", "AZEDBT", JdeDataType.String, 30, true, true),
        new JdeField("AZK70IT", "AZK70IT", JdeDataType.String, 4),
        new JdeField("AZK70SER", "AZK70SER", JdeDataType.String, 40),
        new JdeField("AZK70ENUM", "AZK70ENUM", JdeDataType.String, 72),
        new JdeField("AZUSER", "AZUSER", JdeDataType.String, 20),
        new JdeField("AZPID", "AZPID", JdeDataType.String, 20),
        new JdeField("AZJOBN", "AZJOBN", JdeDataType.String, 20),
        new JdeField("AZUPMJ", "AZUPMJ", JdeDataType.Numeric),
        new JdeField("AZTDAY", "AZTDAY", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F703B1Z1_0", "Primary Key on AZEDUS, AZEDBT, AZEDTN", new[] { "AZEDUS", "AZEDBT", "AZEDTN" }, isUnique: true, isPrimaryKey: true)
    };
}
