using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F40500 - .
/// </summary>
public class F40500 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// CCCMDCDE.
        /// </summary>
        public const string CCCMDCDE = "CCCMDCDE";

        /// <summary>
        /// CCCMDDSC.
        /// </summary>
        public const string CCCMDDSC = "CCCMDDSC";

        /// <summary>
        /// CCCMDPRT.
        /// </summary>
        public const string CCCMDPRT = "CCCMDPRT";

        /// <summary>
        /// CCCATLVL.
        /// </summary>
        public const string CCCATLVL = "CCCATLVL";

        /// <summary>
        /// CCCMDPOS.
        /// </summary>
        public const string CCCMDPOS = "CCCMDPOS";

        /// <summary>
        /// CCLNTY.
        /// </summary>
        public const string CCLNTY = "CCLNTY";

        /// <summary>
        /// CCANBY.
        /// </summary>
        public const string CCANBY = "CCANBY";

        /// <summary>
        /// CCGLC.
        /// </summary>
        public const string CCGLC = "CCGLC";

        /// <summary>
        /// CCCMDCDE01.
        /// </summary>
        public const string CCCMDCDE01 = "CCCMDCDE01";

        /// <summary>
        /// CCCMDDSC01.
        /// </summary>
        public const string CCCMDDSC01 = "CCCMDDSC01";

        /// <summary>
        /// CCCMDCDE02.
        /// </summary>
        public const string CCCMDCDE02 = "CCCMDCDE02";

        /// <summary>
        /// CCCMDDSC02.
        /// </summary>
        public const string CCCMDDSC02 = "CCCMDDSC02";

        /// <summary>
        /// CCCMDCDE03.
        /// </summary>
        public const string CCCMDCDE03 = "CCCMDCDE03";

        /// <summary>
        /// CCCMDDSC03.
        /// </summary>
        public const string CCCMDDSC03 = "CCCMDDSC03";

        /// <summary>
        /// CCCMDCDE04.
        /// </summary>
        public const string CCCMDCDE04 = "CCCMDCDE04";

        /// <summary>
        /// CCCMDDSC04.
        /// </summary>
        public const string CCCMDDSC04 = "CCCMDDSC04";

        /// <summary>
        /// CCCMDCDE05.
        /// </summary>
        public const string CCCMDCDE05 = "CCCMDCDE05";

        /// <summary>
        /// CCCMDDSC05.
        /// </summary>
        public const string CCCMDDSC05 = "CCCMDDSC05";

        /// <summary>
        /// CCCMDCDE06.
        /// </summary>
        public const string CCCMDCDE06 = "CCCMDCDE06";

        /// <summary>
        /// CCCMDDSC06.
        /// </summary>
        public const string CCCMDDSC06 = "CCCMDDSC06";

        /// <summary>
        /// CCUSER.
        /// </summary>
        public const string CCUSER = "CCUSER";

        /// <summary>
        /// CCPID.
        /// </summary>
        public const string CCPID = "CCPID";

        /// <summary>
        /// CCJOBN.
        /// </summary>
        public const string CCJOBN = "CCJOBN";

        /// <summary>
        /// CCUPMT.
        /// </summary>
        public const string CCUPMT = "CCUPMT";

        /// <summary>
        /// CCUPMJ.
        /// </summary>
        public const string CCUPMJ = "CCUPMJ";
    }

    /// <inheritdoc />
    public override string TableName => "F40500";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("CCCMDCDE", "CCCMDCDE", JdeDataType.String, 30, true, true),
        new JdeField("CCCMDDSC", "CCCMDDSC", JdeDataType.String, 60),
        new JdeField("CCCMDPRT", "CCCMDPRT", JdeDataType.String, 30),
        new JdeField("CCCATLVL", "CCCATLVL", JdeDataType.Numeric),
        new JdeField("CCCMDPOS", "CCCMDPOS", JdeDataType.String, 2),
        new JdeField("CCLNTY", "CCLNTY", JdeDataType.String, 4),
        new JdeField("CCANBY", "CCANBY", JdeDataType.Numeric),
        new JdeField("CCGLC", "CCGLC", JdeDataType.String, 8),
        new JdeField("CCCMDCDE01", "CCCMDCDE01", JdeDataType.String, 30),
        new JdeField("CCCMDDSC01", "CCCMDDSC01", JdeDataType.String, 60),
        new JdeField("CCCMDCDE02", "CCCMDCDE02", JdeDataType.String, 30),
        new JdeField("CCCMDDSC02", "CCCMDDSC02", JdeDataType.String, 60),
        new JdeField("CCCMDCDE03", "CCCMDCDE03", JdeDataType.String, 30),
        new JdeField("CCCMDDSC03", "CCCMDDSC03", JdeDataType.String, 60),
        new JdeField("CCCMDCDE04", "CCCMDCDE04", JdeDataType.String, 30),
        new JdeField("CCCMDDSC04", "CCCMDDSC04", JdeDataType.String, 60),
        new JdeField("CCCMDCDE05", "CCCMDCDE05", JdeDataType.String, 30),
        new JdeField("CCCMDDSC05", "CCCMDDSC05", JdeDataType.String, 60),
        new JdeField("CCCMDCDE06", "CCCMDCDE06", JdeDataType.String, 30),
        new JdeField("CCCMDDSC06", "CCCMDDSC06", JdeDataType.String, 60),
        new JdeField("CCUSER", "CCUSER", JdeDataType.String, 20),
        new JdeField("CCPID", "CCPID", JdeDataType.String, 20),
        new JdeField("CCJOBN", "CCJOBN", JdeDataType.String, 20),
        new JdeField("CCUPMT", "CCUPMT", JdeDataType.Numeric),
        new JdeField("CCUPMJ", "CCUPMJ", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F40500_0", "Primary Key on CCCMDCDE", new[] { "CCCMDCDE" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F40500_2", "Index on CCCMDCDE, CCCMDPRT", new[] { "CCCMDCDE", "CCCMDPRT" }),
        new JdeIndex("F40500_3", "Index on CCCMDPRT, CCCATLVL, CCCMDPOS", new[] { "CCCMDPRT", "CCCATLVL", "CCCMDPOS" }),
        new JdeIndex("F40500_4", "Index on CCCMDPRT", new[] { "CCCMDPRT" })
    };
}
