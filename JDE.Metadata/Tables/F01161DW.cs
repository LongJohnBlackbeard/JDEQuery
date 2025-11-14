using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F01161DW - .
/// </summary>
public class F01161DW : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// DWAN8.
        /// </summary>
        public const string DWAN8 = "DWAN8";

        /// <summary>
        /// DWIDLN.
        /// </summary>
        public const string DWIDLN = "DWIDLN";

        /// <summary>
        /// DWATYPE.
        /// </summary>
        public const string DWATYPE = "DWATYPE";

        /// <summary>
        /// DWEFTB.
        /// </summary>
        public const string DWEFTB = "DWEFTB";

        /// <summary>
        /// DWCKEY.
        /// </summary>
        public const string DWCKEY = "DWCKEY";

        /// <summary>
        /// DWALPH.
        /// </summary>
        public const string DWALPH = "DWALPH";

        /// <summary>
        /// DWALPH1.
        /// </summary>
        public const string DWALPH1 = "DWALPH1";

        /// <summary>
        /// DWADD1.
        /// </summary>
        public const string DWADD1 = "DWADD1";

        /// <summary>
        /// DWADD2.
        /// </summary>
        public const string DWADD2 = "DWADD2";

        /// <summary>
        /// DWADD3.
        /// </summary>
        public const string DWADD3 = "DWADD3";

        /// <summary>
        /// DWADD4.
        /// </summary>
        public const string DWADD4 = "DWADD4";

        /// <summary>
        /// DWCTY1.
        /// </summary>
        public const string DWCTY1 = "DWCTY1";

        /// <summary>
        /// DWADDS.
        /// </summary>
        public const string DWADDS = "DWADDS";

        /// <summary>
        /// DWADDZ.
        /// </summary>
        public const string DWADDZ = "DWADDZ";

        /// <summary>
        /// DWCOUN.
        /// </summary>
        public const string DWCOUN = "DWCOUN";

        /// <summary>
        /// DWCTR.
        /// </summary>
        public const string DWCTR = "DWCTR";

        /// <summary>
        /// DWMAINA.
        /// </summary>
        public const string DWMAINA = "DWMAINA";

        /// <summary>
        /// DWUSER.
        /// </summary>
        public const string DWUSER = "DWUSER";

        /// <summary>
        /// DWPID.
        /// </summary>
        public const string DWPID = "DWPID";

        /// <summary>
        /// DWUPMJ.
        /// </summary>
        public const string DWUPMJ = "DWUPMJ";

        /// <summary>
        /// DWUPMT.
        /// </summary>
        public const string DWUPMT = "DWUPMT";

        /// <summary>
        /// DWMACH.
        /// </summary>
        public const string DWMACH = "DWMACH";
    }

    /// <inheritdoc />
    public override string TableName => "F01161DW";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("DWAN8", "DWAN8", JdeDataType.Numeric, null, true, true),
        new JdeField("DWIDLN", "DWIDLN", JdeDataType.Numeric, null, true, true),
        new JdeField("DWATYPE", "DWATYPE", JdeDataType.String, 10, true, true),
        new JdeField("DWEFTB", "DWEFTB", JdeDataType.Numeric, null, true, true),
        new JdeField("DWCKEY", "DWCKEY", JdeDataType.String, 80),
        new JdeField("DWALPH", "DWALPH", JdeDataType.String, 80),
        new JdeField("DWALPH1", "DWALPH1", JdeDataType.String, 80),
        new JdeField("DWADD1", "DWADD1", JdeDataType.String, 80),
        new JdeField("DWADD2", "DWADD2", JdeDataType.String, 80),
        new JdeField("DWADD3", "DWADD3", JdeDataType.String, 80),
        new JdeField("DWADD4", "DWADD4", JdeDataType.String, 80),
        new JdeField("DWCTY1", "DWCTY1", JdeDataType.String, 50),
        new JdeField("DWADDS", "DWADDS", JdeDataType.String, 6),
        new JdeField("DWADDZ", "DWADDZ", JdeDataType.String, 24),
        new JdeField("DWCOUN", "DWCOUN", JdeDataType.String, 50),
        new JdeField("DWCTR", "DWCTR", JdeDataType.String, 6),
        new JdeField("DWMAINA", "DWMAINA", JdeDataType.String, 2),
        new JdeField("DWUSER", "DWUSER", JdeDataType.String, 20),
        new JdeField("DWPID", "DWPID", JdeDataType.String, 20),
        new JdeField("DWUPMJ", "DWUPMJ", JdeDataType.Numeric),
        new JdeField("DWUPMT", "DWUPMT", JdeDataType.Numeric),
        new JdeField("DWMACH", "DWMACH", JdeDataType.String, 24)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F01161DW_0", "Primary Key on DWAN8, DWIDLN, DWATYPE, DWEFTB", new[] { "DWAN8", "DWIDLN", "DWATYPE", "DWEFTB" }, isUnique: true, isPrimaryKey: true)
    };
}
