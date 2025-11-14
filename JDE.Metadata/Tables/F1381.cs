using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F1381 - .
/// </summary>
public class F1381 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// EFEQGP.
        /// </summary>
        public const string EFEQGP = "EFEQGP";

        /// <summary>
        /// EFEQSP.
        /// </summary>
        public const string EFEQSP = "EFEQSP";

        /// <summary>
        /// EFICLC.
        /// </summary>
        public const string EFICLC = "EFICLC";

        /// <summary>
        /// EFCO.
        /// </summary>
        public const string EFCO = "EFCO";

        /// <summary>
        /// EFMCU.
        /// </summary>
        public const string EFMCU = "EFMCU";

        /// <summary>
        /// EFLOC.
        /// </summary>
        public const string EFLOC = "EFLOC";

        /// <summary>
        /// EFAN8.
        /// </summary>
        public const string EFAN8 = "EFAN8";

        /// <summary>
        /// EFLANO.
        /// </summary>
        public const string EFLANO = "EFLANO";

        /// <summary>
        /// EFEQST.
        /// </summary>
        public const string EFEQST = "EFEQST";

        /// <summary>
        /// EFAAID.
        /// </summary>
        public const string EFAAID = "EFAAID";

        /// <summary>
        /// EFPRODM.
        /// </summary>
        public const string EFPRODM = "EFPRODM";

        /// <summary>
        /// EFPRODF.
        /// </summary>
        public const string EFPRODF = "EFPRODF";

        /// <summary>
        /// EFMMCU.
        /// </summary>
        public const string EFMMCU = "EFMMCU";

        /// <summary>
        /// EFNUMB.
        /// </summary>
        public const string EFNUMB = "EFNUMB";

        /// <summary>
        /// EFKIT.
        /// </summary>
        public const string EFKIT = "EFKIT";

        /// <summary>
        /// EFACL1.
        /// </summary>
        public const string EFACL1 = "EFACL1";

        /// <summary>
        /// EFACL2.
        /// </summary>
        public const string EFACL2 = "EFACL2";

        /// <summary>
        /// EFACL3.
        /// </summary>
        public const string EFACL3 = "EFACL3";

        /// <summary>
        /// EFACL4.
        /// </summary>
        public const string EFACL4 = "EFACL4";

        /// <summary>
        /// EFACL5.
        /// </summary>
        public const string EFACL5 = "EFACL5";

        /// <summary>
        /// EFACL6.
        /// </summary>
        public const string EFACL6 = "EFACL6";

        /// <summary>
        /// EFACL7.
        /// </summary>
        public const string EFACL7 = "EFACL7";

        /// <summary>
        /// EFACL8.
        /// </summary>
        public const string EFACL8 = "EFACL8";

        /// <summary>
        /// EFACL9.
        /// </summary>
        public const string EFACL9 = "EFACL9";

        /// <summary>
        /// EFACL0.
        /// </summary>
        public const string EFACL0 = "EFACL0";

        /// <summary>
        /// EFFA1.
        /// </summary>
        public const string EFFA1 = "EFFA1";

        /// <summary>
        /// EFFA2.
        /// </summary>
        public const string EFFA2 = "EFFA2";

        /// <summary>
        /// EFFA3.
        /// </summary>
        public const string EFFA3 = "EFFA3";

        /// <summary>
        /// EFFA4.
        /// </summary>
        public const string EFFA4 = "EFFA4";

        /// <summary>
        /// EFFA5.
        /// </summary>
        public const string EFFA5 = "EFFA5";

        /// <summary>
        /// EFFA6.
        /// </summary>
        public const string EFFA6 = "EFFA6";

        /// <summary>
        /// EFFA7.
        /// </summary>
        public const string EFFA7 = "EFFA7";

        /// <summary>
        /// EFFA8.
        /// </summary>
        public const string EFFA8 = "EFFA8";

        /// <summary>
        /// EFFA9.
        /// </summary>
        public const string EFFA9 = "EFFA9";

        /// <summary>
        /// EFFA0.
        /// </summary>
        public const string EFFA0 = "EFFA0";

        /// <summary>
        /// EFFA21.
        /// </summary>
        public const string EFFA21 = "EFFA21";

        /// <summary>
        /// EFFA22.
        /// </summary>
        public const string EFFA22 = "EFFA22";

        /// <summary>
        /// EFFA23.
        /// </summary>
        public const string EFFA23 = "EFFA23";

        /// <summary>
        /// EFZE01.
        /// </summary>
        public const string EFZE01 = "EFZE01";

        /// <summary>
        /// EFZE02.
        /// </summary>
        public const string EFZE02 = "EFZE02";

        /// <summary>
        /// EFZE03.
        /// </summary>
        public const string EFZE03 = "EFZE03";

        /// <summary>
        /// EFZE04.
        /// </summary>
        public const string EFZE04 = "EFZE04";

        /// <summary>
        /// EFZE05.
        /// </summary>
        public const string EFZE05 = "EFZE05";

        /// <summary>
        /// EFZE06.
        /// </summary>
        public const string EFZE06 = "EFZE06";

        /// <summary>
        /// EFZE07.
        /// </summary>
        public const string EFZE07 = "EFZE07";

        /// <summary>
        /// EFZE08.
        /// </summary>
        public const string EFZE08 = "EFZE08";

        /// <summary>
        /// EFZE09.
        /// </summary>
        public const string EFZE09 = "EFZE09";

        /// <summary>
        /// EFZE10.
        /// </summary>
        public const string EFZE10 = "EFZE10";

        /// <summary>
        /// EFUSER.
        /// </summary>
        public const string EFUSER = "EFUSER";

        /// <summary>
        /// EFPID.
        /// </summary>
        public const string EFPID = "EFPID";

        /// <summary>
        /// EFMKEY.
        /// </summary>
        public const string EFMKEY = "EFMKEY";

        /// <summary>
        /// EFUPMJ.
        /// </summary>
        public const string EFUPMJ = "EFUPMJ";

        /// <summary>
        /// EFUPMT.
        /// </summary>
        public const string EFUPMT = "EFUPMT";
    }

    /// <inheritdoc />
    public override string TableName => "F1381";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("EFEQGP", "EFEQGP", JdeDataType.String, 60, true, true),
        new JdeField("EFEQSP", "EFEQSP", JdeDataType.String, 60, true, true),
        new JdeField("EFICLC", "EFICLC", JdeDataType.String, 2),
        new JdeField("EFCO", "EFCO", JdeDataType.String, 10),
        new JdeField("EFMCU", "EFMCU", JdeDataType.String, 24),
        new JdeField("EFLOC", "EFLOC", JdeDataType.String, 24),
        new JdeField("EFAN8", "EFAN8", JdeDataType.Numeric),
        new JdeField("EFLANO", "EFLANO", JdeDataType.Numeric),
        new JdeField("EFEQST", "EFEQST", JdeDataType.String, 4),
        new JdeField("EFAAID", "EFAAID", JdeDataType.Numeric),
        new JdeField("EFPRODM", "EFPRODM", JdeDataType.String, 16),
        new JdeField("EFPRODF", "EFPRODF", JdeDataType.String, 16),
        new JdeField("EFMMCU", "EFMMCU", JdeDataType.String, 24),
        new JdeField("EFNUMB", "EFNUMB", JdeDataType.Numeric),
        new JdeField("EFKIT", "EFKIT", JdeDataType.Numeric),
        new JdeField("EFACL1", "EFACL1", JdeDataType.String, 6),
        new JdeField("EFACL2", "EFACL2", JdeDataType.String, 6),
        new JdeField("EFACL3", "EFACL3", JdeDataType.String, 6),
        new JdeField("EFACL4", "EFACL4", JdeDataType.String, 6),
        new JdeField("EFACL5", "EFACL5", JdeDataType.String, 6),
        new JdeField("EFACL6", "EFACL6", JdeDataType.String, 6),
        new JdeField("EFACL7", "EFACL7", JdeDataType.String, 6),
        new JdeField("EFACL8", "EFACL8", JdeDataType.String, 6),
        new JdeField("EFACL9", "EFACL9", JdeDataType.String, 6),
        new JdeField("EFACL0", "EFACL0", JdeDataType.String, 6),
        new JdeField("EFFA1", "EFFA1", JdeDataType.String, 6),
        new JdeField("EFFA2", "EFFA2", JdeDataType.String, 6),
        new JdeField("EFFA3", "EFFA3", JdeDataType.String, 6),
        new JdeField("EFFA4", "EFFA4", JdeDataType.String, 6),
        new JdeField("EFFA5", "EFFA5", JdeDataType.String, 6),
        new JdeField("EFFA6", "EFFA6", JdeDataType.String, 6),
        new JdeField("EFFA7", "EFFA7", JdeDataType.String, 6),
        new JdeField("EFFA8", "EFFA8", JdeDataType.String, 6),
        new JdeField("EFFA9", "EFFA9", JdeDataType.String, 6),
        new JdeField("EFFA0", "EFFA0", JdeDataType.String, 6),
        new JdeField("EFFA21", "EFFA21", JdeDataType.String, 20),
        new JdeField("EFFA22", "EFFA22", JdeDataType.String, 20),
        new JdeField("EFFA23", "EFFA23", JdeDataType.String, 20),
        new JdeField("EFZE01", "EFZE01", JdeDataType.String, 20),
        new JdeField("EFZE02", "EFZE02", JdeDataType.String, 20),
        new JdeField("EFZE03", "EFZE03", JdeDataType.String, 20),
        new JdeField("EFZE04", "EFZE04", JdeDataType.String, 20),
        new JdeField("EFZE05", "EFZE05", JdeDataType.String, 20),
        new JdeField("EFZE06", "EFZE06", JdeDataType.String, 20),
        new JdeField("EFZE07", "EFZE07", JdeDataType.String, 20),
        new JdeField("EFZE08", "EFZE08", JdeDataType.String, 20),
        new JdeField("EFZE09", "EFZE09", JdeDataType.String, 20),
        new JdeField("EFZE10", "EFZE10", JdeDataType.String, 20),
        new JdeField("EFUSER", "EFUSER", JdeDataType.String, 20),
        new JdeField("EFPID", "EFPID", JdeDataType.String, 20),
        new JdeField("EFMKEY", "EFMKEY", JdeDataType.String, 30),
        new JdeField("EFUPMJ", "EFUPMJ", JdeDataType.Numeric),
        new JdeField("EFUPMT", "EFUPMT", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F1381_0", "Primary Key on EFEQGP, EFEQSP", new[] { "EFEQGP", "EFEQSP" }, isUnique: true, isPrimaryKey: true)
    };
}
