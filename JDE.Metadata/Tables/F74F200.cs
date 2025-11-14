using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F74F200 - .
/// </summary>
public class F74F200 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// CFFY.
        /// </summary>
        public const string CFFY = "CFFY";

        /// <summary>
        /// CFCO.
        /// </summary>
        public const string CFCO = "CFCO";

        /// <summary>
        /// CFPN.
        /// </summary>
        public const string CFPN = "CFPN";

        /// <summary>
        /// CFF74FECST.
        /// </summary>
        public const string CFF74FECST = "CFF74FECST";

        /// <summary>
        /// CFUSER.
        /// </summary>
        public const string CFUSER = "CFUSER";

        /// <summary>
        /// CFPID.
        /// </summary>
        public const string CFPID = "CFPID";

        /// <summary>
        /// CFUPMJ.
        /// </summary>
        public const string CFUPMJ = "CFUPMJ";

        /// <summary>
        /// CFUPMT.
        /// </summary>
        public const string CFUPMT = "CFUPMT";

        /// <summary>
        /// CFJOBN.
        /// </summary>
        public const string CFJOBN = "CFJOBN";
    }

    /// <inheritdoc />
    public override string TableName => "F74F200";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("CFFY", "CFFY", JdeDataType.Numeric, null, true, true),
        new JdeField("CFCO", "CFCO", JdeDataType.String, 10, true, true),
        new JdeField("CFPN", "CFPN", JdeDataType.Numeric),
        new JdeField("CFF74FECST", "CFF74FECST", JdeDataType.String, 4),
        new JdeField("CFUSER", "CFUSER", JdeDataType.String, 20),
        new JdeField("CFPID", "CFPID", JdeDataType.String, 20),
        new JdeField("CFUPMJ", "CFUPMJ", JdeDataType.Numeric),
        new JdeField("CFUPMT", "CFUPMT", JdeDataType.Numeric),
        new JdeField("CFJOBN", "CFJOBN", JdeDataType.String, 20)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F74F200_0", "Primary Key on CFFY, CFCO", new[] { "CFFY", "CFCO" }, isUnique: true, isPrimaryKey: true)
    };
}
