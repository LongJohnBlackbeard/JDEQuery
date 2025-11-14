using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F76B0540 - .
/// </summary>
public class F76B0540 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// BWJOBS.
        /// </summary>
        public const string BWJOBS = "BWJOBS";

        /// <summary>
        /// BWBNNF.
        /// </summary>
        public const string BWBNNF = "BWBNNF";

        /// <summary>
        /// BWBSER.
        /// </summary>
        public const string BWBSER = "BWBSER";

        /// <summary>
        /// BWN001.
        /// </summary>
        public const string BWN001 = "BWN001";

        /// <summary>
        /// BWDCT.
        /// </summary>
        public const string BWDCT = "BWDCT";

        /// <summary>
        /// BWUKID.
        /// </summary>
        public const string BWUKID = "BWUKID";

        /// <summary>
        /// BWBRAOB2.
        /// </summary>
        public const string BWBRAOB2 = "BWBRAOB2";

        /// <summary>
        /// BWAN8.
        /// </summary>
        public const string BWAN8 = "BWAN8";

        /// <summary>
        /// BWGENCHAR.
        /// </summary>
        public const string BWGENCHAR = "BWGENCHAR";

        /// <summary>
        /// BWKY.
        /// </summary>
        public const string BWKY = "BWKY";

        /// <summary>
        /// BWINT01.
        /// </summary>
        public const string BWINT01 = "BWINT01";

        /// <summary>
        /// BWBVTN.
        /// </summary>
        public const string BWBVTN = "BWBVTN";

        /// <summary>
        /// BWBBCS.
        /// </summary>
        public const string BWBBCS = "BWBBCS";

        /// <summary>
        /// BWAA.
        /// </summary>
        public const string BWAA = "BWAA";

        /// <summary>
        /// BWBISS.
        /// </summary>
        public const string BWBISS = "BWBISS";

        /// <summary>
        /// BWTXR3.
        /// </summary>
        public const string BWTXR3 = "BWTXR3";

        /// <summary>
        /// BWINT02.
        /// </summary>
        public const string BWINT02 = "BWINT02";

        /// <summary>
        /// BWUSER.
        /// </summary>
        public const string BWUSER = "BWUSER";

        /// <summary>
        /// BWPID.
        /// </summary>
        public const string BWPID = "BWPID";

        /// <summary>
        /// BWJOBN.
        /// </summary>
        public const string BWJOBN = "BWJOBN";

        /// <summary>
        /// BWUPMT.
        /// </summary>
        public const string BWUPMT = "BWUPMT";

        /// <summary>
        /// BWUPMJ.
        /// </summary>
        public const string BWUPMJ = "BWUPMJ";
    }

    /// <inheritdoc />
    public override string TableName => "F76B0540";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("BWJOBS", "BWJOBS", JdeDataType.Numeric, null, true, true),
        new JdeField("BWBNNF", "BWBNNF", JdeDataType.Numeric, null, true, true),
        new JdeField("BWBSER", "BWBSER", JdeDataType.String, 4, true, true),
        new JdeField("BWN001", "BWN001", JdeDataType.Numeric, null, true, true),
        new JdeField("BWDCT", "BWDCT", JdeDataType.String, 4, true, true),
        new JdeField("BWUKID", "BWUKID", JdeDataType.Numeric, null, true, true),
        new JdeField("BWBRAOB2", "BWBRAOB2", JdeDataType.String, 2),
        new JdeField("BWAN8", "BWAN8", JdeDataType.Numeric),
        new JdeField("BWGENCHAR", "BWGENCHAR", JdeDataType.String, 2),
        new JdeField("BWKY", "BWKY", JdeDataType.String, 20),
        new JdeField("BWINT01", "BWINT01", JdeDataType.Numeric),
        new JdeField("BWBVTN", "BWBVTN", JdeDataType.Numeric),
        new JdeField("BWBBCS", "BWBBCS", JdeDataType.Numeric),
        new JdeField("BWAA", "BWAA", JdeDataType.Numeric),
        new JdeField("BWBISS", "BWBISS", JdeDataType.Numeric),
        new JdeField("BWTXR3", "BWTXR3", JdeDataType.Numeric),
        new JdeField("BWINT02", "BWINT02", JdeDataType.Numeric),
        new JdeField("BWUSER", "BWUSER", JdeDataType.String, 20),
        new JdeField("BWPID", "BWPID", JdeDataType.String, 20),
        new JdeField("BWJOBN", "BWJOBN", JdeDataType.String, 20),
        new JdeField("BWUPMT", "BWUPMT", JdeDataType.Numeric),
        new JdeField("BWUPMJ", "BWUPMJ", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F76B0540_0", "Primary Key on BWJOBS, BWBNNF, BWBSER, BWN001, BWDCT, BWUKID", new[] { "BWJOBS", "BWBNNF", "BWBSER", "BWN001", "BWDCT", "BWUKID" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F76B0540_2", "Index on BWGENCHAR, BWBNNF, BWBSER, BWN001", new[] { "BWGENCHAR", "BWBNNF", "BWBSER", "BWN001" })
    };
}
