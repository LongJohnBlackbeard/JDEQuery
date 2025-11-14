using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F48424 - .
/// </summary>
public class F48424 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// STCO.
        /// </summary>
        public const string STCO = "STCO";

        /// <summary>
        /// STSBMCU.
        /// </summary>
        public const string STSBMCU = "STSBMCU";

        /// <summary>
        /// STSBPROJ.
        /// </summary>
        public const string STSBPROJ = "STSBPROJ";

        /// <summary>
        /// STSBCUST.
        /// </summary>
        public const string STSBCUST = "STSBCUST";

        /// <summary>
        /// STSBSBL.
        /// </summary>
        public const string STSBSBL = "STSBSBL";

        /// <summary>
        /// STSBADR.
        /// </summary>
        public const string STSBADR = "STSBADR";

        /// <summary>
        /// STSBRP11.
        /// </summary>
        public const string STSBRP11 = "STSBRP11";

        /// <summary>
        /// STSBWR07.
        /// </summary>
        public const string STSBWR07 = "STSBWR07";

        /// <summary>
        /// STSBOBJ.
        /// </summary>
        public const string STSBOBJ = "STSBOBJ";

        /// <summary>
        /// STSBSUB.
        /// </summary>
        public const string STSBSUB = "STSBSUB";

        /// <summary>
        /// STUPMJ.
        /// </summary>
        public const string STUPMJ = "STUPMJ";

        /// <summary>
        /// STUPMT.
        /// </summary>
        public const string STUPMT = "STUPMT";

        /// <summary>
        /// STJOBN.
        /// </summary>
        public const string STJOBN = "STJOBN";

        /// <summary>
        /// STUSER.
        /// </summary>
        public const string STUSER = "STUSER";

        /// <summary>
        /// STPID.
        /// </summary>
        public const string STPID = "STPID";
    }

    /// <inheritdoc />
    public override string TableName => "F48424";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("STCO", "STCO", JdeDataType.String, 10, true, true),
        new JdeField("STSBMCU", "STSBMCU", JdeDataType.Numeric),
        new JdeField("STSBPROJ", "STSBPROJ", JdeDataType.Numeric),
        new JdeField("STSBCUST", "STSBCUST", JdeDataType.Numeric),
        new JdeField("STSBSBL", "STSBSBL", JdeDataType.Numeric),
        new JdeField("STSBADR", "STSBADR", JdeDataType.Numeric),
        new JdeField("STSBRP11", "STSBRP11", JdeDataType.Numeric),
        new JdeField("STSBWR07", "STSBWR07", JdeDataType.Numeric),
        new JdeField("STSBOBJ", "STSBOBJ", JdeDataType.Numeric),
        new JdeField("STSBSUB", "STSBSUB", JdeDataType.Numeric),
        new JdeField("STUPMJ", "STUPMJ", JdeDataType.Numeric),
        new JdeField("STUPMT", "STUPMT", JdeDataType.Numeric),
        new JdeField("STJOBN", "STJOBN", JdeDataType.String, 20),
        new JdeField("STUSER", "STUSER", JdeDataType.String, 20),
        new JdeField("STPID", "STPID", JdeDataType.String, 20)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F48424_0", "Primary Key on STCO", new[] { "STCO" }, isUnique: true, isPrimaryKey: true)
    };
}
