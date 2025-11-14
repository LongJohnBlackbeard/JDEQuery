using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F87SAR - .
/// </summary>
public class F87SAR : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// WSDOCO.
        /// </summary>
        public const string WSDOCO = "WSDOCO";

        /// <summary>
        /// WSDL01.
        /// </summary>
        public const string WSDL01 = "WSDL01";

        /// <summary>
        /// WSTYPS.
        /// </summary>
        public const string WSTYPS = "WSTYPS";

        /// <summary>
        /// WSSY1.
        /// </summary>
        public const string WSSY1 = "WSSY1";

        /// <summary>
        /// WSOBNM.
        /// </summary>
        public const string WSOBNM = "WSOBNM";

        /// <summary>
        /// WSLTRN.
        /// </summary>
        public const string WSLTRN = "WSLTRN";

        /// <summary>
        /// WSSTRX.
        /// </summary>
        public const string WSSTRX = "WSSTRX";

        /// <summary>
        /// WSBRLS.
        /// </summary>
        public const string WSBRLS = "WSBRLS";

        /// <summary>
        /// WSPTF.
        /// </summary>
        public const string WSPTF = "WSPTF";

        /// <summary>
        /// WSVR01.
        /// </summary>
        public const string WSVR01 = "WSVR01";

        /// <summary>
        /// WSANP.
        /// </summary>
        public const string WSANP = "WSANP";

        /// <summary>
        /// WSPRTS.
        /// </summary>
        public const string WSPRTS = "WSPRTS";
    }

    /// <inheritdoc />
    public override string TableName => "F87SAR";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("WSDOCO", "WSDOCO", JdeDataType.Numeric, null, true, true),
        new JdeField("WSDL01", "WSDL01", JdeDataType.String, 60),
        new JdeField("WSTYPS", "WSTYPS", JdeDataType.String, 2),
        new JdeField("WSSY1", "WSSY1", JdeDataType.String, 8),
        new JdeField("WSOBNM", "WSOBNM", JdeDataType.String, 20, true, true),
        new JdeField("WSLTRN", "WSLTRN", JdeDataType.Numeric),
        new JdeField("WSSTRX", "WSSTRX", JdeDataType.Numeric),
        new JdeField("WSBRLS", "WSBRLS", JdeDataType.String, 20, true, true),
        new JdeField("WSPTF", "WSPTF", JdeDataType.String, 20, true, true),
        new JdeField("WSVR01", "WSVR01", JdeDataType.String, 50),
        new JdeField("WSANP", "WSANP", JdeDataType.Numeric),
        new JdeField("WSPRTS", "WSPRTS", JdeDataType.String, 2)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F87SAR_0", "Primary Key on WSDOCO, WSOBNM, WSBRLS, WSPTF", new[] { "WSDOCO", "WSOBNM", "WSBRLS", "WSPTF" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F87SAR_2", "Index on WSOBNM, WSBRLS, WSPTF, WSLTRN", new[] { "WSOBNM", "WSBRLS", "WSPTF", "WSLTRN" })
    };
}
