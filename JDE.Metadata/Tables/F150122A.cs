using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F150122A - .
/// </summary>
public class F150122A : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// SAICU.
        /// </summary>
        public const string SAICU = "SAICU";

        /// <summary>
        /// SASFDN.
        /// </summary>
        public const string SASFDN = "SASFDN";

        /// <summary>
        /// SAECMP.
        /// </summary>
        public const string SAECMP = "SAECMP";

        /// <summary>
        /// SAGLMD.
        /// </summary>
        public const string SAGLMD = "SAGLMD";

        /// <summary>
        /// SAMCUS.
        /// </summary>
        public const string SAMCUS = "SAMCUS";

        /// <summary>
        /// SAMCU.
        /// </summary>
        public const string SAMCU = "SAMCU";

        /// <summary>
        /// SAUNIT.
        /// </summary>
        public const string SAUNIT = "SAUNIT";

        /// <summary>
        /// SAMT.
        /// </summary>
        public const string SAMT = "SAMT";

        /// <summary>
        /// SACENTYR.
        /// </summary>
        public const string SACENTYR = "SACENTYR";

        /// <summary>
        /// SAARDEFID.
        /// </summary>
        public const string SAARDEFID = "SAARDEFID";

        /// <summary>
        /// SAARTY.
        /// </summary>
        public const string SAARTY = "SAARTY";

        /// <summary>
        /// SAAM01.
        /// </summary>
        public const string SAAM01 = "SAAM01";

        /// <summary>
        /// SAGLAA.
        /// </summary>
        public const string SAGLAA = "SAGLAA";

        /// <summary>
        /// SAGLOA.
        /// </summary>
        public const string SAGLOA = "SAGLOA";

        /// <summary>
        /// SACPVA.
        /// </summary>
        public const string SACPVA = "SACPVA";

        /// <summary>
        /// SACAPA.
        /// </summary>
        public const string SACAPA = "SACAPA";

        /// <summary>
        /// SAUSER.
        /// </summary>
        public const string SAUSER = "SAUSER";

        /// <summary>
        /// SAPID.
        /// </summary>
        public const string SAPID = "SAPID";

        /// <summary>
        /// SAMKEY.
        /// </summary>
        public const string SAMKEY = "SAMKEY";

        /// <summary>
        /// SAUPMJ.
        /// </summary>
        public const string SAUPMJ = "SAUPMJ";

        /// <summary>
        /// SAUPMT.
        /// </summary>
        public const string SAUPMT = "SAUPMT";

        /// <summary>
        /// SATORG.
        /// </summary>
        public const string SATORG = "SATORG";

        /// <summary>
        /// SAENTJ.
        /// </summary>
        public const string SAENTJ = "SAENTJ";

        /// <summary>
        /// SACRCD.
        /// </summary>
        public const string SACRCD = "SACRCD";
    }

    /// <inheritdoc />
    public override string TableName => "F150122A";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("SAICU", "SAICU", JdeDataType.Numeric, null, true, true),
        new JdeField("SASFDN", "SASFDN", JdeDataType.String, 20, true, true),
        new JdeField("SAECMP", "SAECMP", JdeDataType.String, 2, true, true),
        new JdeField("SAGLMD", "SAGLMD", JdeDataType.String, 2, true, true),
        new JdeField("SAMCUS", "SAMCUS", JdeDataType.String, 24, true, true),
        new JdeField("SAMCU", "SAMCU", JdeDataType.String, 24, true, true),
        new JdeField("SAUNIT", "SAUNIT", JdeDataType.String, 16, true, true),
        new JdeField("SAMT", "SAMT", JdeDataType.Numeric, null, true, true),
        new JdeField("SACENTYR", "SACENTYR", JdeDataType.Numeric, null, true, true),
        new JdeField("SAARDEFID", "SAARDEFID", JdeDataType.String, 20, true, true),
        new JdeField("SAARTY", "SAARTY", JdeDataType.String, 6),
        new JdeField("SAAM01", "SAAM01", JdeDataType.String, 6),
        new JdeField("SAGLAA", "SAGLAA", JdeDataType.Numeric),
        new JdeField("SAGLOA", "SAGLOA", JdeDataType.Numeric),
        new JdeField("SACPVA", "SACPVA", JdeDataType.Numeric),
        new JdeField("SACAPA", "SACAPA", JdeDataType.Numeric),
        new JdeField("SAUSER", "SAUSER", JdeDataType.String, 20),
        new JdeField("SAPID", "SAPID", JdeDataType.String, 20),
        new JdeField("SAMKEY", "SAMKEY", JdeDataType.String, 30),
        new JdeField("SAUPMJ", "SAUPMJ", JdeDataType.Numeric),
        new JdeField("SAUPMT", "SAUPMT", JdeDataType.Numeric),
        new JdeField("SATORG", "SATORG", JdeDataType.String, 20),
        new JdeField("SAENTJ", "SAENTJ", JdeDataType.Numeric),
        new JdeField("SACRCD", "SACRCD", JdeDataType.String, 6)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F150122A_0", "Primary Key on SAICU, SASFDN, SAECMP, SAGLMD, SAMCUS, SAMCU, SAUNIT, SAMT, SACENTYR, SAARDEFID", new[] { "SAICU", "SASFDN", "SAECMP", "SAGLMD", "SAMCUS", "SAMCU", "SAUNIT", "SAMT", "SACENTYR", "SAARDEFID" }, isUnique: true, isPrimaryKey: true)
    };
}
