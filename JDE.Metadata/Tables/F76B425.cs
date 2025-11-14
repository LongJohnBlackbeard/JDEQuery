using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F76B425 - .
/// </summary>
public class F76B425 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// FNKCOO.
        /// </summary>
        public const string FNKCOO = "FNKCOO";

        /// <summary>
        /// FNDOCO.
        /// </summary>
        public const string FNDOCO = "FNDOCO";

        /// <summary>
        /// FNDCTO.
        /// </summary>
        public const string FNDCTO = "FNDCTO";

        /// <summary>
        /// FNDCT.
        /// </summary>
        public const string FNDCT = "FNDCT";

        /// <summary>
        /// FNISSU.
        /// </summary>
        public const string FNISSU = "FNISSU";

        /// <summary>
        /// FNB76TNF.
        /// </summary>
        public const string FNB76TNF = "FNB76TNF";

        /// <summary>
        /// FNBNNF.
        /// </summary>
        public const string FNBNNF = "FNBNNF";

        /// <summary>
        /// FNBSER.
        /// </summary>
        public const string FNBSER = "FNBSER";

        /// <summary>
        /// FNB76ELN.
        /// </summary>
        public const string FNB76ELN = "FNB76ELN";

        /// <summary>
        /// FNB76SNF.
        /// </summary>
        public const string FNB76SNF = "FNB76SNF";

        /// <summary>
        /// FNB76AKEY.
        /// </summary>
        public const string FNB76AKEY = "FNB76AKEY";

        /// <summary>
        /// FNTORG.
        /// </summary>
        public const string FNTORG = "FNTORG";

        /// <summary>
        /// FNUSER.
        /// </summary>
        public const string FNUSER = "FNUSER";

        /// <summary>
        /// FNPID.
        /// </summary>
        public const string FNPID = "FNPID";

        /// <summary>
        /// FNJOBN.
        /// </summary>
        public const string FNJOBN = "FNJOBN";

        /// <summary>
        /// FNUPMJ.
        /// </summary>
        public const string FNUPMJ = "FNUPMJ";

        /// <summary>
        /// FNUPMT.
        /// </summary>
        public const string FNUPMT = "FNUPMT";
    }

    /// <inheritdoc />
    public override string TableName => "F76B425";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("FNKCOO", "FNKCOO", JdeDataType.String, 10, true, true),
        new JdeField("FNDOCO", "FNDOCO", JdeDataType.Numeric, null, true, true),
        new JdeField("FNDCTO", "FNDCTO", JdeDataType.String, 4, true, true),
        new JdeField("FNDCT", "FNDCT", JdeDataType.String, 4),
        new JdeField("FNISSU", "FNISSU", JdeDataType.Numeric),
        new JdeField("FNB76TNF", "FNB76TNF", JdeDataType.String, 20),
        new JdeField("FNBNNF", "FNBNNF", JdeDataType.Numeric),
        new JdeField("FNBSER", "FNBSER", JdeDataType.String, 4),
        new JdeField("FNB76ELN", "FNB76ELN", JdeDataType.String, 60),
        new JdeField("FNB76SNF", "FNB76SNF", JdeDataType.String, 6),
        new JdeField("FNB76AKEY", "FNB76AKEY", JdeDataType.String, 88),
        new JdeField("FNTORG", "FNTORG", JdeDataType.String, 20),
        new JdeField("FNUSER", "FNUSER", JdeDataType.String, 20),
        new JdeField("FNPID", "FNPID", JdeDataType.String, 20),
        new JdeField("FNJOBN", "FNJOBN", JdeDataType.String, 20),
        new JdeField("FNUPMJ", "FNUPMJ", JdeDataType.Numeric),
        new JdeField("FNUPMT", "FNUPMT", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F76B425_0", "Primary Key on FNKCOO, FNDOCO, FNDCTO", new[] { "FNKCOO", "FNDOCO", "FNDCTO" }, isUnique: true, isPrimaryKey: true)
    };
}
