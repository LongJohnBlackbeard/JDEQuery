using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F03B118 - .
/// </summary>
public class F03B118 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// RMCO.
        /// </summary>
        public const string RMCO = "RMCO";

        /// <summary>
        /// RMCRCD.
        /// </summary>
        public const string RMCRCD = "RMCRCD";

        /// <summary>
        /// RMDCT.
        /// </summary>
        public const string RMDCT = "RMDCT";

        /// <summary>
        /// RMDOC.
        /// </summary>
        public const string RMDOC = "RMDOC";

        /// <summary>
        /// RMKCO.
        /// </summary>
        public const string RMKCO = "RMKCO";

        /// <summary>
        /// RMSFX.
        /// </summary>
        public const string RMSFX = "RMSFX";

        /// <summary>
        /// RMLNID.
        /// </summary>
        public const string RMLNID = "RMLNID";

        /// <summary>
        /// RMDRR.
        /// </summary>
        public const string RMDRR = "RMDRR";

        /// <summary>
        /// RMDGJ.
        /// </summary>
        public const string RMDGJ = "RMDGJ";

        /// <summary>
        /// RMAAR.
        /// </summary>
        public const string RMAAR = "RMAAR";

        /// <summary>
        /// RMAARE.
        /// </summary>
        public const string RMAARE = "RMAARE";

        /// <summary>
        /// RMAARN.
        /// </summary>
        public const string RMAARN = "RMAARN";

        /// <summary>
        /// RMRSTU.
        /// </summary>
        public const string RMRSTU = "RMRSTU";

        /// <summary>
        /// RMAARI.
        /// </summary>
        public const string RMAARI = "RMAARI";

        /// <summary>
        /// RMRRC.
        /// </summary>
        public const string RMRRC = "RMRRC";

        /// <summary>
        /// RMFAAR.
        /// </summary>
        public const string RMFAAR = "RMFAAR";

        /// <summary>
        /// RMFAARE.
        /// </summary>
        public const string RMFAARE = "RMFAARE";

        /// <summary>
        /// RMFAARN.
        /// </summary>
        public const string RMFAARN = "RMFAARN";

        /// <summary>
        /// RMFAARI.
        /// </summary>
        public const string RMFAARI = "RMFAARI";

        /// <summary>
        /// RMUPMJ.
        /// </summary>
        public const string RMUPMJ = "RMUPMJ";

        /// <summary>
        /// RMUPMT.
        /// </summary>
        public const string RMUPMT = "RMUPMT";

        /// <summary>
        /// RMUSER.
        /// </summary>
        public const string RMUSER = "RMUSER";

        /// <summary>
        /// RMPID.
        /// </summary>
        public const string RMPID = "RMPID";

        /// <summary>
        /// RMJOBN.
        /// </summary>
        public const string RMJOBN = "RMJOBN";

        /// <summary>
        /// RMEDRR.
        /// </summary>
        public const string RMEDRR = "RMEDRR";

        /// <summary>
        /// RMEPDA.
        /// </summary>
        public const string RMEPDA = "RMEPDA";

        /// <summary>
        /// RMCH6.
        /// </summary>
        public const string RMCH6 = "RMCH6";

        /// <summary>
        /// RMDJ6.
        /// </summary>
        public const string RMDJ6 = "RMDJ6";
    }

    /// <inheritdoc />
    public override string TableName => "F03B118";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("RMCO", "RMCO", JdeDataType.String, 10),
        new JdeField("RMCRCD", "RMCRCD", JdeDataType.String, 6),
        new JdeField("RMDCT", "RMDCT", JdeDataType.String, 4, true, true),
        new JdeField("RMDOC", "RMDOC", JdeDataType.Numeric, null, true, true),
        new JdeField("RMKCO", "RMKCO", JdeDataType.String, 10, true, true),
        new JdeField("RMSFX", "RMSFX", JdeDataType.String, 6, true, true),
        new JdeField("RMLNID", "RMLNID", JdeDataType.Numeric, null, true, true),
        new JdeField("RMDRR", "RMDRR", JdeDataType.Numeric),
        new JdeField("RMDGJ", "RMDGJ", JdeDataType.Numeric),
        new JdeField("RMAAR", "RMAAR", JdeDataType.Numeric),
        new JdeField("RMAARE", "RMAARE", JdeDataType.Numeric),
        new JdeField("RMAARN", "RMAARN", JdeDataType.Numeric),
        new JdeField("RMRSTU", "RMRSTU", JdeDataType.String, 2),
        new JdeField("RMAARI", "RMAARI", JdeDataType.Numeric),
        new JdeField("RMRRC", "RMRRC", JdeDataType.String, 2),
        new JdeField("RMFAAR", "RMFAAR", JdeDataType.Numeric),
        new JdeField("RMFAARE", "RMFAARE", JdeDataType.Numeric),
        new JdeField("RMFAARN", "RMFAARN", JdeDataType.Numeric),
        new JdeField("RMFAARI", "RMFAARI", JdeDataType.Numeric),
        new JdeField("RMUPMJ", "RMUPMJ", JdeDataType.Numeric),
        new JdeField("RMUPMT", "RMUPMT", JdeDataType.Numeric),
        new JdeField("RMUSER", "RMUSER", JdeDataType.String, 20),
        new JdeField("RMPID", "RMPID", JdeDataType.String, 20),
        new JdeField("RMJOBN", "RMJOBN", JdeDataType.String, 20),
        new JdeField("RMEDRR", "RMEDRR", JdeDataType.Numeric),
        new JdeField("RMEPDA", "RMEPDA", JdeDataType.Numeric),
        new JdeField("RMCH6", "RMCH6", JdeDataType.String, 2),
        new JdeField("RMDJ6", "RMDJ6", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F03B118_0", "Primary Key on RMDCT, RMDOC, RMKCO, RMSFX, RMLNID", new[] { "RMDCT", "RMDOC", "RMKCO", "RMSFX", "RMLNID" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F03B118_2", "Index on RMDCT, RMDOC, RMKCO, RMSFX, SYS_NC00029$", new[] { "RMDCT", "RMDOC", "RMKCO", "RMSFX", "SYS_NC00029$" })
    };
}
