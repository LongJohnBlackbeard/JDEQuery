using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F74U4319 - .
/// </summary>
public class F74U4319 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// CSKCOO.
        /// </summary>
        public const string CSKCOO = "CSKCOO";

        /// <summary>
        /// CSDOCO.
        /// </summary>
        public const string CSDOCO = "CSDOCO";

        /// <summary>
        /// CSDCTO.
        /// </summary>
        public const string CSDCTO = "CSDCTO";

        /// <summary>
        /// CSSFXO.
        /// </summary>
        public const string CSSFXO = "CSSFXO";

        /// <summary>
        /// CSLNID.
        /// </summary>
        public const string CSLNID = "CSLNID";

        /// <summary>
        /// CSUKCECA.
        /// </summary>
        public const string CSUKCECA = "CSUKCECA";

        /// <summary>
        /// CS74UCLAD.
        /// </summary>
        public const string CS74UCLAD = "CS74UCLAD";

        /// <summary>
        /// CS74UCMAD.
        /// </summary>
        public const string CS74UCMAD = "CS74UCMAD";

        /// <summary>
        /// CSURCD.
        /// </summary>
        public const string CSURCD = "CSURCD";

        /// <summary>
        /// CSURAT.
        /// </summary>
        public const string CSURAT = "CSURAT";

        /// <summary>
        /// CSURAB.
        /// </summary>
        public const string CSURAB = "CSURAB";

        /// <summary>
        /// CSURRF.
        /// </summary>
        public const string CSURRF = "CSURRF";

        /// <summary>
        /// CSURDT.
        /// </summary>
        public const string CSURDT = "CSURDT";

        /// <summary>
        /// CSPID.
        /// </summary>
        public const string CSPID = "CSPID";

        /// <summary>
        /// CSUSER.
        /// </summary>
        public const string CSUSER = "CSUSER";

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
    public override string TableName => "F74U4319";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("CSKCOO", "CSKCOO", JdeDataType.String, 10, true, true),
        new JdeField("CSDOCO", "CSDOCO", JdeDataType.Numeric, null, true, true),
        new JdeField("CSDCTO", "CSDCTO", JdeDataType.String, 4, true, true),
        new JdeField("CSSFXO", "CSSFXO", JdeDataType.String, 6, true, true),
        new JdeField("CSLNID", "CSLNID", JdeDataType.Numeric, null, true, true),
        new JdeField("CSUKCECA", "CSUKCECA", JdeDataType.Numeric),
        new JdeField("CS74UCLAD", "CS74UCLAD", JdeDataType.Numeric),
        new JdeField("CS74UCMAD", "CS74UCMAD", JdeDataType.Numeric),
        new JdeField("CSURCD", "CSURCD", JdeDataType.String, 4),
        new JdeField("CSURAT", "CSURAT", JdeDataType.Numeric),
        new JdeField("CSURAB", "CSURAB", JdeDataType.Numeric),
        new JdeField("CSURRF", "CSURRF", JdeDataType.String, 30),
        new JdeField("CSURDT", "CSURDT", JdeDataType.Numeric),
        new JdeField("CSPID", "CSPID", JdeDataType.String, 20),
        new JdeField("CSUSER", "CSUSER", JdeDataType.String, 20),
        new JdeField("CSJOBN", "CSJOBN", JdeDataType.String, 20),
        new JdeField("CSUPMJ", "CSUPMJ", JdeDataType.Numeric),
        new JdeField("CSUPMT", "CSUPMT", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F74U4319_0", "Primary Key on CSKCOO, CSDOCO, CSDCTO, CSSFXO, CSLNID", new[] { "CSKCOO", "CSDOCO", "CSDCTO", "CSSFXO", "CSLNID" }, isUnique: true, isPrimaryKey: true)
    };
}
