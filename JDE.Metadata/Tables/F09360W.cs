using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F09360W - .
/// </summary>
public class F09360W : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// CLRUNID.
        /// </summary>
        public const string CLRUNID = "CLRUNID";

        /// <summary>
        /// CLLINN.
        /// </summary>
        public const string CLLINN = "CLLINN";

        /// <summary>
        /// CLCSTN.
        /// </summary>
        public const string CLCSTN = "CLCSTN";

        /// <summary>
        /// CLCOLNBR.
        /// </summary>
        public const string CLCOLNBR = "CLCOLNBR";

        /// <summary>
        /// CLCTRY.
        /// </summary>
        public const string CLCTRY = "CLCTRY";

        /// <summary>
        /// CLFY.
        /// </summary>
        public const string CLFY = "CLFY";

        /// <summary>
        /// CLLT.
        /// </summary>
        public const string CLLT = "CLLT";

        /// <summary>
        /// CLFPN.
        /// </summary>
        public const string CLFPN = "CLFPN";

        /// <summary>
        /// CLTPN.
        /// </summary>
        public const string CLTPN = "CLTPN";

        /// <summary>
        /// CLBLNOP.
        /// </summary>
        public const string CLBLNOP = "CLBLNOP";

        /// <summary>
        /// CLQRYE.
        /// </summary>
        public const string CLQRYE = "CLQRYE";

        /// <summary>
        /// CLUSER.
        /// </summary>
        public const string CLUSER = "CLUSER";

        /// <summary>
        /// CLRPSTN.
        /// </summary>
        public const string CLRPSTN = "CLRPSTN";

        /// <summary>
        /// CLVERN.
        /// </summary>
        public const string CLVERN = "CLVERN";
    }

    /// <inheritdoc />
    public override string TableName => "F09360W";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("CLRUNID", "CLRUNID", JdeDataType.Numeric, null, true, true),
        new JdeField("CLLINN", "CLLINN", JdeDataType.Numeric, null, true, true),
        new JdeField("CLCSTN", "CLCSTN", JdeDataType.String, 40, true, true),
        new JdeField("CLCOLNBR", "CLCOLNBR", JdeDataType.Numeric),
        new JdeField("CLCTRY", "CLCTRY", JdeDataType.Numeric),
        new JdeField("CLFY", "CLFY", JdeDataType.Numeric),
        new JdeField("CLLT", "CLLT", JdeDataType.String, 4),
        new JdeField("CLFPN", "CLFPN", JdeDataType.Numeric),
        new JdeField("CLTPN", "CLTPN", JdeDataType.Numeric),
        new JdeField("CLBLNOP", "CLBLNOP", JdeDataType.String, 4),
        new JdeField("CLQRYE", "CLQRYE", JdeDataType.String, 2),
        new JdeField("CLUSER", "CLUSER", JdeDataType.String, 20),
        new JdeField("CLRPSTN", "CLRPSTN", JdeDataType.String, 40),
        new JdeField("CLVERN", "CLVERN", JdeDataType.String, 40)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F09360W_0", "Primary Key on CLRUNID, CLLINN, CLCSTN", new[] { "CLRUNID", "CLLINN", "CLCSTN" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F09360W_2", "Index on CLRUNID, CLLINN, CLQRYE", new[] { "CLRUNID", "CLLINN", "CLQRYE" }),
        new JdeIndex("F09360W_3", "Index on CLUSER, CLRPSTN, CLVERN", new[] { "CLUSER", "CLRPSTN", "CLVERN" }),
        new JdeIndex("F09360W_4", "Index on CLRUNID, CLLINN, CLCOLNBR", new[] { "CLRUNID", "CLLINN", "CLCOLNBR" })
    };
}
