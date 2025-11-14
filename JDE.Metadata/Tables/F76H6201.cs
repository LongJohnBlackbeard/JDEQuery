using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F76H6201 - .
/// </summary>
public class F76H6201 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// RHH76LECO.
        /// </summary>
        public const string RHH76LECO = "RHH76LECO";

        /// <summary>
        /// RHCFY.
        /// </summary>
        public const string RHCFY = "RHCFY";

        /// <summary>
        /// RHFFP.
        /// </summary>
        public const string RHFFP = "RHFFP";

        /// <summary>
        /// RHFTP.
        /// </summary>
        public const string RHFTP = "RHFTP";

        /// <summary>
        /// RHH76RCPIS.
        /// </summary>
        public const string RHH76RCPIS = "RHH76RCPIS";

        /// <summary>
        /// RHH76RCNPI.
        /// </summary>
        public const string RHH76RCNPI = "RHH76RCNPI";

        /// <summary>
        /// RHH76RCJES.
        /// </summary>
        public const string RHH76RCJES = "RHH76RCJES";

        /// <summary>
        /// RHAAJU.
        /// </summary>
        public const string RHAAJU = "RHAAJU";

        /// <summary>
        /// RHDCT.
        /// </summary>
        public const string RHDCT = "RHDCT";

        /// <summary>
        /// RHLT.
        /// </summary>
        public const string RHLT = "RHLT";

        /// <summary>
        /// RHDGJ.
        /// </summary>
        public const string RHDGJ = "RHDGJ";

        /// <summary>
        /// RHREVR.
        /// </summary>
        public const string RHREVR = "RHREVR";

        /// <summary>
        /// RHICUT.
        /// </summary>
        public const string RHICUT = "RHICUT";

        /// <summary>
        /// RHICU.
        /// </summary>
        public const string RHICU = "RHICU";

        /// <summary>
        /// RHTORG.
        /// </summary>
        public const string RHTORG = "RHTORG";

        /// <summary>
        /// RHUSER.
        /// </summary>
        public const string RHUSER = "RHUSER";

        /// <summary>
        /// RHPID.
        /// </summary>
        public const string RHPID = "RHPID";

        /// <summary>
        /// RHJOBN.
        /// </summary>
        public const string RHJOBN = "RHJOBN";

        /// <summary>
        /// RHUPMJ.
        /// </summary>
        public const string RHUPMJ = "RHUPMJ";

        /// <summary>
        /// RHUPMT.
        /// </summary>
        public const string RHUPMT = "RHUPMT";
    }

    /// <inheritdoc />
    public override string TableName => "F76H6201";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("RHH76LECO", "RHH76LECO", JdeDataType.String, 10, true, true),
        new JdeField("RHCFY", "RHCFY", JdeDataType.Numeric, null, true, true),
        new JdeField("RHFFP", "RHFFP", JdeDataType.Numeric, null, true, true),
        new JdeField("RHFTP", "RHFTP", JdeDataType.Numeric),
        new JdeField("RHH76RCPIS", "RHH76RCPIS", JdeDataType.String, 2),
        new JdeField("RHH76RCNPI", "RHH76RCNPI", JdeDataType.String, 2),
        new JdeField("RHH76RCJES", "RHH76RCJES", JdeDataType.String, 2),
        new JdeField("RHAAJU", "RHAAJU", JdeDataType.String, 20),
        new JdeField("RHDCT", "RHDCT", JdeDataType.String, 4),
        new JdeField("RHLT", "RHLT", JdeDataType.String, 4),
        new JdeField("RHDGJ", "RHDGJ", JdeDataType.Numeric),
        new JdeField("RHREVR", "RHREVR", JdeDataType.String, 2),
        new JdeField("RHICUT", "RHICUT", JdeDataType.String, 4),
        new JdeField("RHICU", "RHICU", JdeDataType.Numeric),
        new JdeField("RHTORG", "RHTORG", JdeDataType.String, 20),
        new JdeField("RHUSER", "RHUSER", JdeDataType.String, 20),
        new JdeField("RHPID", "RHPID", JdeDataType.String, 20),
        new JdeField("RHJOBN", "RHJOBN", JdeDataType.String, 20),
        new JdeField("RHUPMJ", "RHUPMJ", JdeDataType.Numeric),
        new JdeField("RHUPMT", "RHUPMT", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F76H6201_0", "Primary Key on RHH76LECO, RHCFY, RHFFP", new[] { "RHH76LECO", "RHCFY", "RHFFP" }, isUnique: true, isPrimaryKey: true)
    };
}
