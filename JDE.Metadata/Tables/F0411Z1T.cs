using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F0411Z1T - .
/// </summary>
public class F0411Z1T : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// VTEDUS.
        /// </summary>
        public const string VTEDUS = "VTEDUS";

        /// <summary>
        /// VTEDBT.
        /// </summary>
        public const string VTEDBT = "VTEDBT";

        /// <summary>
        /// VTEDTN.
        /// </summary>
        public const string VTEDTN = "VTEDTN";

        /// <summary>
        /// VTEDLN.
        /// </summary>
        public const string VTEDLN = "VTEDLN";

        /// <summary>
        /// VTDOCO.
        /// </summary>
        public const string VTDOCO = "VTDOCO";

        /// <summary>
        /// VTDCTO.
        /// </summary>
        public const string VTDCTO = "VTDCTO";

        /// <summary>
        /// VTKCOO.
        /// </summary>
        public const string VTKCOO = "VTKCOO";

        /// <summary>
        /// VTSFXO.
        /// </summary>
        public const string VTSFXO = "VTSFXO";

        /// <summary>
        /// VTLNID.
        /// </summary>
        public const string VTLNID = "VTLNID";

        /// <summary>
        /// VTNLIN.
        /// </summary>
        public const string VTNLIN = "VTNLIN";

        /// <summary>
        /// VTDOC.
        /// </summary>
        public const string VTDOC = "VTDOC";

        /// <summary>
        /// VTITM.
        /// </summary>
        public const string VTITM = "VTITM";

        /// <summary>
        /// VTLITM.
        /// </summary>
        public const string VTLITM = "VTLITM";

        /// <summary>
        /// VTCITM.
        /// </summary>
        public const string VTCITM = "VTCITM";

        /// <summary>
        /// VTSTAVM.
        /// </summary>
        public const string VTSTAVM = "VTSTAVM";

        /// <summary>
        /// VTINVLYN.
        /// </summary>
        public const string VTINVLYN = "VTINVLYN";

        /// <summary>
        /// VTFUSS1.
        /// </summary>
        public const string VTFUSS1 = "VTFUSS1";

        /// <summary>
        /// VTFUSS2.
        /// </summary>
        public const string VTFUSS2 = "VTFUSS2";

        /// <summary>
        /// VTFUSS3.
        /// </summary>
        public const string VTFUSS3 = "VTFUSS3";

        /// <summary>
        /// VTFUSS4.
        /// </summary>
        public const string VTFUSS4 = "VTFUSS4";

        /// <summary>
        /// VTFUSS5.
        /// </summary>
        public const string VTFUSS5 = "VTFUSS5";

        /// <summary>
        /// VTFUSN1.
        /// </summary>
        public const string VTFUSN1 = "VTFUSN1";

        /// <summary>
        /// VTFUSN2.
        /// </summary>
        public const string VTFUSN2 = "VTFUSN2";

        /// <summary>
        /// VTFUSN3.
        /// </summary>
        public const string VTFUSN3 = "VTFUSN3";

        /// <summary>
        /// VTFUSN4.
        /// </summary>
        public const string VTFUSN4 = "VTFUSN4";

        /// <summary>
        /// VTFUSN5.
        /// </summary>
        public const string VTFUSN5 = "VTFUSN5";

        /// <summary>
        /// VTFUSC1.
        /// </summary>
        public const string VTFUSC1 = "VTFUSC1";

        /// <summary>
        /// VTFUSC2.
        /// </summary>
        public const string VTFUSC2 = "VTFUSC2";

        /// <summary>
        /// VTUSER.
        /// </summary>
        public const string VTUSER = "VTUSER";

        /// <summary>
        /// VTPID.
        /// </summary>
        public const string VTPID = "VTPID";

        /// <summary>
        /// VTUPMJ.
        /// </summary>
        public const string VTUPMJ = "VTUPMJ";

        /// <summary>
        /// VTUPMT.
        /// </summary>
        public const string VTUPMT = "VTUPMT";

        /// <summary>
        /// VTJOBN.
        /// </summary>
        public const string VTJOBN = "VTJOBN";
    }

    /// <inheritdoc />
    public override string TableName => "F0411Z1T";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("VTEDUS", "VTEDUS", JdeDataType.String, 20, true, true),
        new JdeField("VTEDBT", "VTEDBT", JdeDataType.String, 30, true, true),
        new JdeField("VTEDTN", "VTEDTN", JdeDataType.String, 44, true, true),
        new JdeField("VTEDLN", "VTEDLN", JdeDataType.Numeric, null, true, true),
        new JdeField("VTDOCO", "VTDOCO", JdeDataType.Numeric, null, true, true),
        new JdeField("VTDCTO", "VTDCTO", JdeDataType.String, 4, true, true),
        new JdeField("VTKCOO", "VTKCOO", JdeDataType.String, 10, true, true),
        new JdeField("VTSFXO", "VTSFXO", JdeDataType.String, 6, true, true),
        new JdeField("VTLNID", "VTLNID", JdeDataType.Numeric, null, true, true),
        new JdeField("VTNLIN", "VTNLIN", JdeDataType.Numeric, null, true, true),
        new JdeField("VTDOC", "VTDOC", JdeDataType.Numeric, null, true, true),
        new JdeField("VTITM", "VTITM", JdeDataType.Numeric),
        new JdeField("VTLITM", "VTLITM", JdeDataType.String, 50),
        new JdeField("VTCITM", "VTCITM", JdeDataType.String, 50),
        new JdeField("VTSTAVM", "VTSTAVM", JdeDataType.String, 2),
        new JdeField("VTINVLYN", "VTINVLYN", JdeDataType.String, 2),
        new JdeField("VTFUSS1", "VTFUSS1", JdeDataType.String, 60),
        new JdeField("VTFUSS2", "VTFUSS2", JdeDataType.String, 60),
        new JdeField("VTFUSS3", "VTFUSS3", JdeDataType.String, 60),
        new JdeField("VTFUSS4", "VTFUSS4", JdeDataType.String, 60),
        new JdeField("VTFUSS5", "VTFUSS5", JdeDataType.String, 60),
        new JdeField("VTFUSN1", "VTFUSN1", JdeDataType.Numeric),
        new JdeField("VTFUSN2", "VTFUSN2", JdeDataType.Numeric),
        new JdeField("VTFUSN3", "VTFUSN3", JdeDataType.Numeric),
        new JdeField("VTFUSN4", "VTFUSN4", JdeDataType.Numeric),
        new JdeField("VTFUSN5", "VTFUSN5", JdeDataType.Numeric),
        new JdeField("VTFUSC1", "VTFUSC1", JdeDataType.String, 2),
        new JdeField("VTFUSC2", "VTFUSC2", JdeDataType.String, 2),
        new JdeField("VTUSER", "VTUSER", JdeDataType.String, 20),
        new JdeField("VTPID", "VTPID", JdeDataType.String, 20),
        new JdeField("VTUPMJ", "VTUPMJ", JdeDataType.Numeric),
        new JdeField("VTUPMT", "VTUPMT", JdeDataType.Numeric),
        new JdeField("VTJOBN", "VTJOBN", JdeDataType.String, 20)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F0411Z1T_0", "Primary Key on VTEDUS, VTEDBT, VTEDTN, VTEDLN, VTDOCO, VTDCTO, VTKCOO, VTSFXO, VTLNID, VTNLIN, VTDOC", new[] { "VTEDUS", "VTEDBT", "VTEDTN", "VTEDLN", "VTDOCO", "VTDCTO", "VTKCOO", "VTSFXO", "VTLNID", "VTNLIN", "VTDOC" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F0411Z1T_2", "Index on VTEDUS, VTEDBT, VTEDTN, VTEDLN", new[] { "VTEDUS", "VTEDBT", "VTEDTN", "VTEDLN" })
    };
}
