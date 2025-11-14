using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F75Z0010 - .
/// </summary>
public class F75Z0010 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// TDAN8.
        /// </summary>
        public const string TDAN8 = "TDAN8";

        /// <summary>
        /// TDCKCN.
        /// </summary>
        public const string TDCKCN = "TDCKCN";

        /// <summary>
        /// TDTARA.
        /// </summary>
        public const string TDTARA = "TDTARA";

        /// <summary>
        /// TDPTAX.
        /// </summary>
        public const string TDPTAX = "TDPTAX";

        /// <summary>
        /// TDINPUTNO.
        /// </summary>
        public const string TDINPUTNO = "TDINPUTNO";

        /// <summary>
        /// TDPAYD.
        /// </summary>
        public const string TDPAYD = "TDPAYD";

        /// <summary>
        /// TDDGJ.
        /// </summary>
        public const string TDDGJ = "TDDGJ";

        /// <summary>
        /// TDGTXBLE.
        /// </summary>
        public const string TDGTXBLE = "TDGTXBLE";

        /// <summary>
        /// TDEARNNL.
        /// </summary>
        public const string TDEARNNL = "TDEARNNL";

        /// <summary>
        /// TDERNPTAX.
        /// </summary>
        public const string TDERNPTAX = "TDERNPTAX";

        /// <summary>
        /// TDLUMPSF.
        /// </summary>
        public const string TDLUMPSF = "TDLUMPSF";

        /// <summary>
        /// TDEPLMF.
        /// </summary>
        public const string TDEPLMF = "TDEPLMF";

        /// <summary>
        /// TDRDRTAF.
        /// </summary>
        public const string TDRDRTAF = "TDRDRTAF";

        /// <summary>
        /// TDPID.
        /// </summary>
        public const string TDPID = "TDPID";

        /// <summary>
        /// TDUSER.
        /// </summary>
        public const string TDUSER = "TDUSER";

        /// <summary>
        /// TDMKEY.
        /// </summary>
        public const string TDMKEY = "TDMKEY";

        /// <summary>
        /// TDUPMJ.
        /// </summary>
        public const string TDUPMJ = "TDUPMJ";

        /// <summary>
        /// TDUPMT.
        /// </summary>
        public const string TDUPMT = "TDUPMT";
    }

    /// <inheritdoc />
    public override string TableName => "F75Z0010";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("TDAN8", "TDAN8", JdeDataType.Numeric, null, true, true),
        new JdeField("TDCKCN", "TDCKCN", JdeDataType.Numeric, null, true, true),
        new JdeField("TDTARA", "TDTARA", JdeDataType.String, 20, true, true),
        new JdeField("TDPTAX", "TDPTAX", JdeDataType.String, 4, true, true),
        new JdeField("TDINPUTNO", "TDINPUTNO", JdeDataType.Numeric, null, true, true),
        new JdeField("TDPAYD", "TDPAYD", JdeDataType.String, 20),
        new JdeField("TDDGJ", "TDDGJ", JdeDataType.Numeric),
        new JdeField("TDGTXBLE", "TDGTXBLE", JdeDataType.Numeric),
        new JdeField("TDEARNNL", "TDEARNNL", JdeDataType.Numeric),
        new JdeField("TDERNPTAX", "TDERNPTAX", JdeDataType.Numeric),
        new JdeField("TDLUMPSF", "TDLUMPSF", JdeDataType.String, 2),
        new JdeField("TDEPLMF", "TDEPLMF", JdeDataType.String, 2),
        new JdeField("TDRDRTAF", "TDRDRTAF", JdeDataType.String, 2),
        new JdeField("TDPID", "TDPID", JdeDataType.String, 20),
        new JdeField("TDUSER", "TDUSER", JdeDataType.String, 20),
        new JdeField("TDMKEY", "TDMKEY", JdeDataType.String, 30),
        new JdeField("TDUPMJ", "TDUPMJ", JdeDataType.Numeric),
        new JdeField("TDUPMT", "TDUPMT", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F75Z0010_0", "Primary Key on TDAN8, TDCKCN, TDTARA, TDPTAX, TDINPUTNO", new[] { "TDAN8", "TDCKCN", "TDTARA", "TDPTAX", "TDINPUTNO" }, isUnique: true, isPrimaryKey: true)
    };
}
