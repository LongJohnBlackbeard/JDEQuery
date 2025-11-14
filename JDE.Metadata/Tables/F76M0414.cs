using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F76M0414 - .
/// </summary>
public class F76M0414 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// RTPYID.
        /// </summary>
        public const string RTPYID = "RTPYID";

        /// <summary>
        /// RTRC5.
        /// </summary>
        public const string RTRC5 = "RTRC5";

        /// <summary>
        /// RTCO.
        /// </summary>
        public const string RTCO = "RTCO";

        /// <summary>
        /// RTDOCM.
        /// </summary>
        public const string RTDOCM = "RTDOCM";

        /// <summary>
        /// RTDCTM.
        /// </summary>
        public const string RTDCTM = "RTDCTM";

        /// <summary>
        /// RTICUT.
        /// </summary>
        public const string RTICUT = "RTICUT";

        /// <summary>
        /// RTICU.
        /// </summary>
        public const string RTICU = "RTICU";

        /// <summary>
        /// RTKCO.
        /// </summary>
        public const string RTKCO = "RTKCO";

        /// <summary>
        /// RTDOC.
        /// </summary>
        public const string RTDOC = "RTDOC";

        /// <summary>
        /// RTDCT.
        /// </summary>
        public const string RTDCT = "RTDCT";

        /// <summary>
        /// RTJELN.
        /// </summary>
        public const string RTJELN = "RTJELN";

        /// <summary>
        /// RTOKCO.
        /// </summary>
        public const string RTOKCO = "RTOKCO";

        /// <summary>
        /// RTODCT.
        /// </summary>
        public const string RTODCT = "RTODCT";

        /// <summary>
        /// RTODOC.
        /// </summary>
        public const string RTODOC = "RTODOC";

        /// <summary>
        /// RTOSFX.
        /// </summary>
        public const string RTOSFX = "RTOSFX";

        /// <summary>
        /// RTSFXE.
        /// </summary>
        public const string RTSFXE = "RTSFXE";

        /// <summary>
        /// RTSTAM.
        /// </summary>
        public const string RTSTAM = "RTSTAM";

        /// <summary>
        /// RTCTAM.
        /// </summary>
        public const string RTCTAM = "RTCTAM";

        /// <summary>
        /// RTBCRC.
        /// </summary>
        public const string RTBCRC = "RTBCRC";

        /// <summary>
        /// RTCRCD.
        /// </summary>
        public const string RTCRCD = "RTCRCD";

        /// <summary>
        /// RTGFL1.
        /// </summary>
        public const string RTGFL1 = "RTGFL1";

        /// <summary>
        /// RTUSER.
        /// </summary>
        public const string RTUSER = "RTUSER";

        /// <summary>
        /// RTPID.
        /// </summary>
        public const string RTPID = "RTPID";

        /// <summary>
        /// RTJOBN.
        /// </summary>
        public const string RTJOBN = "RTJOBN";

        /// <summary>
        /// RTUPMJ.
        /// </summary>
        public const string RTUPMJ = "RTUPMJ";

        /// <summary>
        /// RTUPMT.
        /// </summary>
        public const string RTUPMT = "RTUPMT";
    }

    /// <inheritdoc />
    public override string TableName => "F76M0414";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("RTPYID", "RTPYID", JdeDataType.Numeric, null, true, true),
        new JdeField("RTRC5", "RTRC5", JdeDataType.Numeric, null, true, true),
        new JdeField("RTCO", "RTCO", JdeDataType.String, 10),
        new JdeField("RTDOCM", "RTDOCM", JdeDataType.Numeric),
        new JdeField("RTDCTM", "RTDCTM", JdeDataType.String, 4),
        new JdeField("RTICUT", "RTICUT", JdeDataType.String, 4),
        new JdeField("RTICU", "RTICU", JdeDataType.Numeric),
        new JdeField("RTKCO", "RTKCO", JdeDataType.String, 10),
        new JdeField("RTDOC", "RTDOC", JdeDataType.Numeric),
        new JdeField("RTDCT", "RTDCT", JdeDataType.String, 4),
        new JdeField("RTJELN", "RTJELN", JdeDataType.Numeric, null, true, true),
        new JdeField("RTOKCO", "RTOKCO", JdeDataType.String, 10),
        new JdeField("RTODCT", "RTODCT", JdeDataType.String, 4),
        new JdeField("RTODOC", "RTODOC", JdeDataType.Numeric),
        new JdeField("RTOSFX", "RTOSFX", JdeDataType.String, 6),
        new JdeField("RTSFXE", "RTSFXE", JdeDataType.Numeric),
        new JdeField("RTSTAM", "RTSTAM", JdeDataType.Numeric),
        new JdeField("RTCTAM", "RTCTAM", JdeDataType.Numeric),
        new JdeField("RTBCRC", "RTBCRC", JdeDataType.String, 6),
        new JdeField("RTCRCD", "RTCRCD", JdeDataType.String, 6),
        new JdeField("RTGFL1", "RTGFL1", JdeDataType.String, 2),
        new JdeField("RTUSER", "RTUSER", JdeDataType.String, 20),
        new JdeField("RTPID", "RTPID", JdeDataType.String, 20),
        new JdeField("RTJOBN", "RTJOBN", JdeDataType.String, 20),
        new JdeField("RTUPMJ", "RTUPMJ", JdeDataType.Numeric),
        new JdeField("RTUPMT", "RTUPMT", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F76M0414_0", "Primary Key on RTPYID, RTRC5, RTJELN", new[] { "RTPYID", "RTRC5", "RTJELN" }, isUnique: true, isPrimaryKey: true)
    };
}
