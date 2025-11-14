using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F47006 - .
/// </summary>
public class F47006 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// STEDTY.
        /// </summary>
        public const string STEDTY = "STEDTY";

        /// <summary>
        /// STEDSQ.
        /// </summary>
        public const string STEDSQ = "STEDSQ";

        /// <summary>
        /// STEKCO.
        /// </summary>
        public const string STEKCO = "STEKCO";

        /// <summary>
        /// STEDOC.
        /// </summary>
        public const string STEDOC = "STEDOC";

        /// <summary>
        /// STEDCT.
        /// </summary>
        public const string STEDCT = "STEDCT";

        /// <summary>
        /// STEDLN.
        /// </summary>
        public const string STEDLN = "STEDLN";

        /// <summary>
        /// STEDST.
        /// </summary>
        public const string STEDST = "STEDST";

        /// <summary>
        /// STEDFT.
        /// </summary>
        public const string STEDFT = "STEDFT";

        /// <summary>
        /// STEDDT.
        /// </summary>
        public const string STEDDT = "STEDDT";

        /// <summary>
        /// STEDER.
        /// </summary>
        public const string STEDER = "STEDER";

        /// <summary>
        /// STEDDL.
        /// </summary>
        public const string STEDDL = "STEDDL";

        /// <summary>
        /// STEDSP.
        /// </summary>
        public const string STEDSP = "STEDSP";

        /// <summary>
        /// STEDBT.
        /// </summary>
        public const string STEDBT = "STEDBT";

        /// <summary>
        /// STPNID.
        /// </summary>
        public const string STPNID = "STPNID";

        /// <summary>
        /// STFILE.
        /// </summary>
        public const string STFILE = "STFILE";

        /// <summary>
        /// STKCOO.
        /// </summary>
        public const string STKCOO = "STKCOO";

        /// <summary>
        /// STDOCO.
        /// </summary>
        public const string STDOCO = "STDOCO";

        /// <summary>
        /// STDCTO.
        /// </summary>
        public const string STDCTO = "STDCTO";

        /// <summary>
        /// STSFXO.
        /// </summary>
        public const string STSFXO = "STSFXO";

        /// <summary>
        /// STUTP.
        /// </summary>
        public const string STUTP = "STUTP";

        /// <summary>
        /// STUSER.
        /// </summary>
        public const string STUSER = "STUSER";

        /// <summary>
        /// STPID.
        /// </summary>
        public const string STPID = "STPID";

        /// <summary>
        /// STJOBN.
        /// </summary>
        public const string STJOBN = "STJOBN";

        /// <summary>
        /// STUPMJ.
        /// </summary>
        public const string STUPMJ = "STUPMJ";

        /// <summary>
        /// STUPMT.
        /// </summary>
        public const string STUPMT = "STUPMT";
    }

    /// <inheritdoc />
    public override string TableName => "F47006";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("STEDTY", "STEDTY", JdeDataType.String, 2),
        new JdeField("STEDSQ", "STEDSQ", JdeDataType.Numeric),
        new JdeField("STEKCO", "STEKCO", JdeDataType.String, 10, true, true),
        new JdeField("STEDOC", "STEDOC", JdeDataType.Numeric, null, true, true),
        new JdeField("STEDCT", "STEDCT", JdeDataType.String, 4, true, true),
        new JdeField("STEDLN", "STEDLN", JdeDataType.Numeric),
        new JdeField("STEDST", "STEDST", JdeDataType.String, 12),
        new JdeField("STEDFT", "STEDFT", JdeDataType.String, 20),
        new JdeField("STEDDT", "STEDDT", JdeDataType.Numeric),
        new JdeField("STEDER", "STEDER", JdeDataType.String, 2),
        new JdeField("STEDDL", "STEDDL", JdeDataType.Numeric),
        new JdeField("STEDSP", "STEDSP", JdeDataType.String, 2),
        new JdeField("STEDBT", "STEDBT", JdeDataType.String, 30),
        new JdeField("STPNID", "STPNID", JdeDataType.String, 30),
        new JdeField("STFILE", "STFILE", JdeDataType.String, 20, true, true),
        new JdeField("STKCOO", "STKCOO", JdeDataType.String, 10),
        new JdeField("STDOCO", "STDOCO", JdeDataType.Numeric),
        new JdeField("STDCTO", "STDCTO", JdeDataType.String, 4),
        new JdeField("STSFXO", "STSFXO", JdeDataType.String, 6),
        new JdeField("STUTP", "STUTP", JdeDataType.String, 2),
        new JdeField("STUSER", "STUSER", JdeDataType.String, 20),
        new JdeField("STPID", "STPID", JdeDataType.String, 20),
        new JdeField("STJOBN", "STJOBN", JdeDataType.String, 20),
        new JdeField("STUPMJ", "STUPMJ", JdeDataType.Numeric),
        new JdeField("STUPMT", "STUPMT", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F47006_0", "Primary Key on STFILE, STEDOC, STEDCT, STEKCO", new[] { "STFILE", "STEDOC", "STEDCT", "STEKCO" }, isUnique: true, isPrimaryKey: true)
    };
}
