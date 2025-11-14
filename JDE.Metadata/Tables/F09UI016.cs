using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F09UI016 - .
/// </summary>
public class F09UI016 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// GWUSER.
        /// </summary>
        public const string GWUSER = "GWUSER";

        /// <summary>
        /// GWUPMJ.
        /// </summary>
        public const string GWUPMJ = "GWUPMJ";

        /// <summary>
        /// GWUPMT.
        /// </summary>
        public const string GWUPMT = "GWUPMT";

        /// <summary>
        /// GWAID.
        /// </summary>
        public const string GWAID = "GWAID";

        /// <summary>
        /// GWLT.
        /// </summary>
        public const string GWLT = "GWLT";

        /// <summary>
        /// GWSBLT.
        /// </summary>
        public const string GWSBLT = "GWSBLT";

        /// <summary>
        /// GWSBL.
        /// </summary>
        public const string GWSBL = "GWSBL";

        /// <summary>
        /// GWPN.
        /// </summary>
        public const string GWPN = "GWPN";

        /// <summary>
        /// GWFY.
        /// </summary>
        public const string GWFY = "GWFY";

        /// <summary>
        /// GWCRCD.
        /// </summary>
        public const string GWCRCD = "GWCRCD";

        /// <summary>
        /// GWCRCX.
        /// </summary>
        public const string GWCRCX = "GWCRCX";

        /// <summary>
        /// GWACCTBAL.
        /// </summary>
        public const string GWACCTBAL = "GWACCTBAL";

        /// <summary>
        /// GWTRANSBAL.
        /// </summary>
        public const string GWTRANSBAL = "GWTRANSBAL";

        /// <summary>
        /// GWANI.
        /// </summary>
        public const string GWANI = "GWANI";

        /// <summary>
        /// GWDL01.
        /// </summary>
        public const string GWDL01 = "GWDL01";

        /// <summary>
        /// GWCO.
        /// </summary>
        public const string GWCO = "GWCO";

        /// <summary>
        /// GWCTRY.
        /// </summary>
        public const string GWCTRY = "GWCTRY";

        /// <summary>
        /// GWMCU.
        /// </summary>
        public const string GWMCU = "GWMCU";

        /// <summary>
        /// GWOBJ.
        /// </summary>
        public const string GWOBJ = "GWOBJ";

        /// <summary>
        /// GWSUB.
        /// </summary>
        public const string GWSUB = "GWSUB";

        /// <summary>
        /// GWBALCLEAR.
        /// </summary>
        public const string GWBALCLEAR = "GWBALCLEAR";
    }

    /// <inheritdoc />
    public override string TableName => "F09UI016";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("GWUSER", "GWUSER", JdeDataType.String, 20, true, true),
        new JdeField("GWUPMJ", "GWUPMJ", JdeDataType.Numeric, null, true, true),
        new JdeField("GWUPMT", "GWUPMT", JdeDataType.Numeric, null, true, true),
        new JdeField("GWAID", "GWAID", JdeDataType.String, 16, true, true),
        new JdeField("GWLT", "GWLT", JdeDataType.String, 4, true, true),
        new JdeField("GWSBLT", "GWSBLT", JdeDataType.String, 2, true, true),
        new JdeField("GWSBL", "GWSBL", JdeDataType.String, 16, true, true),
        new JdeField("GWPN", "GWPN", JdeDataType.Numeric, null, true, true),
        new JdeField("GWFY", "GWFY", JdeDataType.Numeric, null, true, true),
        new JdeField("GWCRCD", "GWCRCD", JdeDataType.String, 6, true, true),
        new JdeField("GWCRCX", "GWCRCX", JdeDataType.String, 6),
        new JdeField("GWACCTBAL", "GWACCTBAL", JdeDataType.Numeric),
        new JdeField("GWTRANSBAL", "GWTRANSBAL", JdeDataType.Numeric),
        new JdeField("GWANI", "GWANI", JdeDataType.String, 58),
        new JdeField("GWDL01", "GWDL01", JdeDataType.String, 60),
        new JdeField("GWCO", "GWCO", JdeDataType.String, 10),
        new JdeField("GWCTRY", "GWCTRY", JdeDataType.Numeric),
        new JdeField("GWMCU", "GWMCU", JdeDataType.String, 24),
        new JdeField("GWOBJ", "GWOBJ", JdeDataType.String, 12),
        new JdeField("GWSUB", "GWSUB", JdeDataType.String, 16),
        new JdeField("GWBALCLEAR", "GWBALCLEAR", JdeDataType.String, 2)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F09UI016_0", "Primary Key on GWUSER, GWUPMJ, GWUPMT, GWAID, GWLT, GWSBLT, GWSBL, GWPN, GWFY, GWCRCD", new[] { "GWUSER", "GWUPMJ", "GWUPMT", "GWAID", "GWLT", "GWSBLT", "GWSBL", "GWPN", "GWFY", "GWCRCD" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F09UI016_2", "Index on GWUSER, GWUPMJ, GWUPMT, GWCO, GWMCU, GWOBJ, GWSUB, GWSBLT, GWSBL, GWCTRY, GWFY, GWLT, GWCRCD, GWPN", new[] { "GWUSER", "GWUPMJ", "GWUPMT", "GWCO", "GWMCU", "GWOBJ", "GWSUB", "GWSBLT", "GWSBL", "GWCTRY", "GWFY", "GWLT", "GWCRCD", "GWPN" })
    };
}
