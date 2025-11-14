using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F741201 - .
/// </summary>
public class F741201 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// CSCO.
        /// </summary>
        public const string CSCO = "CSCO";

        /// <summary>
        /// CSC74SC.
        /// </summary>
        public const string CSC74SC = "CSC74SC";

        /// <summary>
        /// CSC74CN.
        /// </summary>
        public const string CSC74CN = "CSC74CN";

        /// <summary>
        /// CSDCT.
        /// </summary>
        public const string CSDCT = "CSDCT";

        /// <summary>
        /// CSUSER.
        /// </summary>
        public const string CSUSER = "CSUSER";

        /// <summary>
        /// CSPID.
        /// </summary>
        public const string CSPID = "CSPID";

        /// <summary>
        /// CSJOBN.
        /// </summary>
        public const string CSJOBN = "CSJOBN";

        /// <summary>
        /// CSUPMJ.
        /// </summary>
        public const string CSUPMJ = "CSUPMJ";

        /// <summary>
        /// CSUPMT.
        /// </summary>
        public const string CSUPMT = "CSUPMT";
    }

    /// <inheritdoc />
    public override string TableName => "F741201";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("CSCO", "CSCO", JdeDataType.String, 10, true, true),
        new JdeField("CSC74SC", "CSC74SC", JdeDataType.String, 20, true, true),
        new JdeField("CSC74CN", "CSC74CN", JdeDataType.String, 6, true, true),
        new JdeField("CSDCT", "CSDCT", JdeDataType.String, 4, true, true),
        new JdeField("CSUSER", "CSUSER", JdeDataType.String, 20),
        new JdeField("CSPID", "CSPID", JdeDataType.String, 20),
        new JdeField("CSJOBN", "CSJOBN", JdeDataType.String, 20),
        new JdeField("CSUPMJ", "CSUPMJ", JdeDataType.Numeric),
        new JdeField("CSUPMT", "CSUPMT", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F741201_0", "Primary Key on CSCO, CSC74SC, CSC74CN, CSDCT", new[] { "CSCO", "CSC74SC", "CSC74CN", "CSDCT" }, isUnique: true, isPrimaryKey: true)
    };
}
