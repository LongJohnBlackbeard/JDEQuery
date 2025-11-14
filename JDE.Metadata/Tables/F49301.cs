using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F49301 - .
/// </summary>
public class F49301 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// VOVEHI.
        /// </summary>
        public const string VOVEHI = "VOVEHI";

        /// <summary>
        /// VOVTYP.
        /// </summary>
        public const string VOVTYP = "VOVTYP";

        /// <summary>
        /// VOCMPN.
        /// </summary>
        public const string VOCMPN = "VOCMPN";

        /// <summary>
        /// VOWTCC.
        /// </summary>
        public const string VOWTCC = "VOWTCC";

        /// <summary>
        /// VOVDGP.
        /// </summary>
        public const string VOVDGP = "VOVDGP";

        /// <summary>
        /// VOVDGS.
        /// </summary>
        public const string VOVDGS = "VOVDGS";

        /// <summary>
        /// VOCVOL.
        /// </summary>
        public const string VOCVOL = "VOCVOL";

        /// <summary>
        /// VOBPFG.
        /// </summary>
        public const string VOBPFG = "VOBPFG";

        /// <summary>
        /// VOMLLN.
        /// </summary>
        public const string VOMLLN = "VOMLLN";

        /// <summary>
        /// VOCSTU.
        /// </summary>
        public const string VOCSTU = "VOCSTU";

        /// <summary>
        /// VODTCL.
        /// </summary>
        public const string VODTCL = "VODTCL";

        /// <summary>
        /// VOTMCL.
        /// </summary>
        public const string VOTMCL = "VOTMCL";

        /// <summary>
        /// VOUSER.
        /// </summary>
        public const string VOUSER = "VOUSER";

        /// <summary>
        /// VOPID.
        /// </summary>
        public const string VOPID = "VOPID";

        /// <summary>
        /// VOJOBN.
        /// </summary>
        public const string VOJOBN = "VOJOBN";

        /// <summary>
        /// VOUPMJ.
        /// </summary>
        public const string VOUPMJ = "VOUPMJ";

        /// <summary>
        /// VOTDAY.
        /// </summary>
        public const string VOTDAY = "VOTDAY";
    }

    /// <inheritdoc />
    public override string TableName => "F49301";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("VOVEHI", "VOVEHI", JdeDataType.String, 24, true, true),
        new JdeField("VOVTYP", "VOVTYP", JdeDataType.String, 24, true, true),
        new JdeField("VOCMPN", "VOCMPN", JdeDataType.Numeric, null, true, true),
        new JdeField("VOWTCC", "VOWTCC", JdeDataType.Numeric),
        new JdeField("VOVDGP", "VOVDGP", JdeDataType.Numeric),
        new JdeField("VOVDGS", "VOVDGS", JdeDataType.Numeric),
        new JdeField("VOCVOL", "VOCVOL", JdeDataType.Numeric),
        new JdeField("VOBPFG", "VOBPFG", JdeDataType.String, 2),
        new JdeField("VOMLLN", "VOMLLN", JdeDataType.String, 2),
        new JdeField("VOCSTU", "VOCSTU", JdeDataType.String, 4),
        new JdeField("VODTCL", "VODTCL", JdeDataType.Numeric),
        new JdeField("VOTMCL", "VOTMCL", JdeDataType.Numeric),
        new JdeField("VOUSER", "VOUSER", JdeDataType.String, 20),
        new JdeField("VOPID", "VOPID", JdeDataType.String, 20),
        new JdeField("VOJOBN", "VOJOBN", JdeDataType.String, 20),
        new JdeField("VOUPMJ", "VOUPMJ", JdeDataType.Numeric),
        new JdeField("VOTDAY", "VOTDAY", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F49301_0", "Primary Key on VOVEHI, VOVTYP, VOCMPN", new[] { "VOVEHI", "VOVTYP", "VOCMPN" }, isUnique: true, isPrimaryKey: true)
    };
}
