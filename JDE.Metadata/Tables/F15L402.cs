using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F15L402 - .
/// </summary>
public class F15L402 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// SGMCU.
        /// </summary>
        public const string SGMCU = "SGMCU";

        /// <summary>
        /// SGRVNB.
        /// </summary>
        public const string SGRVNB = "SGRVNB";

        /// <summary>
        /// SGTEXR.
        /// </summary>
        public const string SGTEXR = "SGTEXR";

        /// <summary>
        /// SGMCUS.
        /// </summary>
        public const string SGMCUS = "SGMCUS";

        /// <summary>
        /// SGECMP.
        /// </summary>
        public const string SGECMP = "SGECMP";

        /// <summary>
        /// SGCRCD.
        /// </summary>
        public const string SGCRCD = "SGCRCD";

        /// <summary>
        /// SGEFTB.
        /// </summary>
        public const string SGEFTB = "SGEFTB";

        /// <summary>
        /// SGEFTE.
        /// </summary>
        public const string SGEFTE = "SGEFTE";

        /// <summary>
        /// SGGLMD.
        /// </summary>
        public const string SGGLMD = "SGGLMD";

        /// <summary>
        /// SGUNIT.
        /// </summary>
        public const string SGUNIT = "SGUNIT";

        /// <summary>
        /// SGGLC.
        /// </summary>
        public const string SGGLC = "SGGLC";

        /// <summary>
        /// SGSFDM.
        /// </summary>
        public const string SGSFDM = "SGSFDM";

        /// <summary>
        /// SGARDEFID.
        /// </summary>
        public const string SGARDEFID = "SGARDEFID";

        /// <summary>
        /// SGSTMB.
        /// </summary>
        public const string SGSTMB = "SGSTMB";

        /// <summary>
        /// SGEXCLRB.
        /// </summary>
        public const string SGEXCLRB = "SGEXCLRB";

        /// <summary>
        /// SGEXCLTOT.
        /// </summary>
        public const string SGEXCLTOT = "SGEXCLTOT";

        /// <summary>
        /// SGAOUTE.
        /// </summary>
        public const string SGAOUTE = "SGAOUTE";

        /// <summary>
        /// SGUSER.
        /// </summary>
        public const string SGUSER = "SGUSER";

        /// <summary>
        /// SGMKEY.
        /// </summary>
        public const string SGMKEY = "SGMKEY";

        /// <summary>
        /// SGPID.
        /// </summary>
        public const string SGPID = "SGPID";

        /// <summary>
        /// SGUPMJ.
        /// </summary>
        public const string SGUPMJ = "SGUPMJ";

        /// <summary>
        /// SGUPMT.
        /// </summary>
        public const string SGUPMT = "SGUPMT";

        /// <summary>
        /// SGTORG.
        /// </summary>
        public const string SGTORG = "SGTORG";

        /// <summary>
        /// SGENTJ.
        /// </summary>
        public const string SGENTJ = "SGENTJ";

        /// <summary>
        /// SGOCCROA.
        /// </summary>
        public const string SGOCCROA = "SGOCCROA";

        /// <summary>
        /// SGAREFODO.
        /// </summary>
        public const string SGAREFODO = "SGAREFODO";

        /// <summary>
        /// SGAM01.
        /// </summary>
        public const string SGAM01 = "SGAM01";

        /// <summary>
        /// SGEXCLRT.
        /// </summary>
        public const string SGEXCLRT = "SGEXCLRT";

        /// <summary>
        /// SGTUATE.
        /// </summary>
        public const string SGTUATE = "SGTUATE";

        /// <summary>
        /// SGEXCLAMT.
        /// </summary>
        public const string SGEXCLAMT = "SGEXCLAMT";

        /// <summary>
        /// SGCENTYR.
        /// </summary>
        public const string SGCENTYR = "SGCENTYR";

        /// <summary>
        /// SGARTY.
        /// </summary>
        public const string SGARTY = "SGARTY";
    }

    /// <inheritdoc />
    public override string TableName => "F15L402";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("SGMCU", "SGMCU", JdeDataType.String, 24, true, true),
        new JdeField("SGRVNB", "SGRVNB", JdeDataType.Numeric, null, true, true),
        new JdeField("SGTEXR", "SGTEXR", JdeDataType.String, 20, true, true),
        new JdeField("SGMCUS", "SGMCUS", JdeDataType.String, 24, true, true),
        new JdeField("SGECMP", "SGECMP", JdeDataType.String, 2, true, true),
        new JdeField("SGCRCD", "SGCRCD", JdeDataType.String, 6, true, true),
        new JdeField("SGEFTB", "SGEFTB", JdeDataType.Numeric, null, true, true),
        new JdeField("SGEFTE", "SGEFTE", JdeDataType.Numeric, null, true, true),
        new JdeField("SGGLMD", "SGGLMD", JdeDataType.String, 2, true, true),
        new JdeField("SGUNIT", "SGUNIT", JdeDataType.String, 16, true, true),
        new JdeField("SGGLC", "SGGLC", JdeDataType.String, 8, true, true),
        new JdeField("SGSFDM", "SGSFDM", JdeDataType.String, 2),
        new JdeField("SGARDEFID", "SGARDEFID", JdeDataType.String, 20),
        new JdeField("SGSTMB", "SGSTMB", JdeDataType.String, 2, true, true),
        new JdeField("SGEXCLRB", "SGEXCLRB", JdeDataType.String, 2, true, true),
        new JdeField("SGEXCLTOT", "SGEXCLTOT", JdeDataType.Numeric),
        new JdeField("SGAOUTE", "SGAOUTE", JdeDataType.Numeric),
        new JdeField("SGUSER", "SGUSER", JdeDataType.String, 20),
        new JdeField("SGMKEY", "SGMKEY", JdeDataType.String, 30),
        new JdeField("SGPID", "SGPID", JdeDataType.String, 20),
        new JdeField("SGUPMJ", "SGUPMJ", JdeDataType.Numeric),
        new JdeField("SGUPMT", "SGUPMT", JdeDataType.Numeric),
        new JdeField("SGTORG", "SGTORG", JdeDataType.String, 20),
        new JdeField("SGENTJ", "SGENTJ", JdeDataType.Numeric),
        new JdeField("SGOCCROA", "SGOCCROA", JdeDataType.String, 2, true, true),
        new JdeField("SGAREFODO", "SGAREFODO", JdeDataType.String, 2),
        new JdeField("SGAM01", "SGAM01", JdeDataType.String, 6),
        new JdeField("SGEXCLRT", "SGEXCLRT", JdeDataType.String, 2, true, true),
        new JdeField("SGTUATE", "SGTUATE", JdeDataType.Numeric),
        new JdeField("SGEXCLAMT", "SGEXCLAMT", JdeDataType.Numeric),
        new JdeField("SGCENTYR", "SGCENTYR", JdeDataType.Numeric),
        new JdeField("SGARTY", "SGARTY", JdeDataType.String, 6)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F15L402_0", "Primary Key on SGMCU, SGRVNB, SGMCUS, SGUNIT, SGTEXR, SGECMP, SGGLMD, SGGLC, SGCRCD, SGOCCROA, SGEFTB, SGEFTE, SGSTMB, SGEXCLRB, SGEXCLRT", new[] { "SGMCU", "SGRVNB", "SGMCUS", "SGUNIT", "SGTEXR", "SGECMP", "SGGLMD", "SGGLC", "SGCRCD", "SGOCCROA", "SGEFTB", "SGEFTE", "SGSTMB", "SGEXCLRB", "SGEXCLRT" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F15L402_2", "Index on SGMCU, SGRVNB", new[] { "SGMCU", "SGRVNB" })
    };
}
