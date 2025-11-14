using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F8907427 - .
/// </summary>
public class F8907427 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// MTMATH01.
        /// </summary>
        public const string MTMATH01 = "MTMATH01";

        /// <summary>
        /// MTEV01.
        /// </summary>
        public const string MTEV01 = "MTEV01";

        /// <summary>
        /// MTDTI1.
        /// </summary>
        public const string MTDTI1 = "MTDTI1";

        /// <summary>
        /// MTMATH02.
        /// </summary>
        public const string MTMATH02 = "MTMATH02";

        /// <summary>
        /// MTALPH1.
        /// </summary>
        public const string MTALPH1 = "MTALPH1";

        /// <summary>
        /// MTTAXX.
        /// </summary>
        public const string MTTAXX = "MTTAXX";

        /// <summary>
        /// MTETAX.
        /// </summary>
        public const string MTETAX = "MTETAX";

        /// <summary>
        /// MTADD4.
        /// </summary>
        public const string MTADD4 = "MTADD4";

        /// <summary>
        /// MTADD5.
        /// </summary>
        public const string MTADD5 = "MTADD5";

        /// <summary>
        /// MTMSCY.
        /// </summary>
        public const string MTMSCY = "MTMSCY";

        /// <summary>
        /// MTSTCD.
        /// </summary>
        public const string MTSTCD = "MTSTCD";

        /// <summary>
        /// MTADDO.
        /// </summary>
        public const string MTADDO = "MTADDO";

        /// <summary>
        /// MTCRRT.
        /// </summary>
        public const string MTCRRT = "MTCRRT";

        /// <summary>
        /// MTDL02.
        /// </summary>
        public const string MTDL02 = "MTDL02";

        /// <summary>
        /// MTFPC2.
        /// </summary>
        public const string MTFPC2 = "MTFPC2";

        /// <summary>
        /// MTALPH3.
        /// </summary>
        public const string MTALPH3 = "MTALPH3";

        /// <summary>
        /// MTPH1.
        /// </summary>
        public const string MTPH1 = "MTPH1";

        /// <summary>
        /// MTPXT1.
        /// </summary>
        public const string MTPXT1 = "MTPXT1";

        /// <summary>
        /// MTPH2.
        /// </summary>
        public const string MTPH2 = "MTPH2";

        /// <summary>
        /// MTEV02.
        /// </summary>
        public const string MTEV02 = "MTEV02";

        /// <summary>
        /// MTADD10.
        /// </summary>
        public const string MTADD10 = "MTADD10";

        /// <summary>
        /// MTADD11.
        /// </summary>
        public const string MTADD11 = "MTADD11";

        /// <summary>
        /// MTCTYNH2.
        /// </summary>
        public const string MTCTYNH2 = "MTCTYNH2";

        /// <summary>
        /// MTADDSNH2.
        /// </summary>
        public const string MTADDSNH2 = "MTADDSNH2";

        /// <summary>
        /// MTADDZNH2.
        /// </summary>
        public const string MTADDZNH2 = "MTADDZNH2";

        /// <summary>
        /// MTCRTENH2.
        /// </summary>
        public const string MTCRTENH2 = "MTCRTENH2";

        /// <summary>
        /// MTDL03.
        /// </summary>
        public const string MTDL03 = "MTDL03";

        /// <summary>
        /// MTFPC4.
        /// </summary>
        public const string MTFPC4 = "MTFPC4";

        /// <summary>
        /// MTDTI2.
        /// </summary>
        public const string MTDTI2 = "MTDTI2";

        /// <summary>
        /// MTSSN.
        /// </summary>
        public const string MTSSN = "MTSSN";

        /// <summary>
        /// MTSRNM.
        /// </summary>
        public const string MTSRNM = "MTSRNM";

        /// <summary>
        /// MTGNNM.
        /// </summary>
        public const string MTGNNM = "MTGNNM";

        /// <summary>
        /// MTMDNM.
        /// </summary>
        public const string MTMDNM = "MTMDNM";

        /// <summary>
        /// MTADD1.
        /// </summary>
        public const string MTADD1 = "MTADD1";

        /// <summary>
        /// MTADD2.
        /// </summary>
        public const string MTADD2 = "MTADD2";

        /// <summary>
        /// MTCTY1.
        /// </summary>
        public const string MTCTY1 = "MTCTY1";

        /// <summary>
        /// MTADDS.
        /// </summary>
        public const string MTADDS = "MTADDS";

        /// <summary>
        /// MTADDZ.
        /// </summary>
        public const string MTADDZ = "MTADDZ";

        /// <summary>
        /// MTCRTE.
        /// </summary>
        public const string MTCRTE = "MTCRTE";

        /// <summary>
        /// MTDL04.
        /// </summary>
        public const string MTDL04 = "MTDL04";

        /// <summary>
        /// MTFPC1.
        /// </summary>
        public const string MTFPC1 = "MTFPC1";

        /// <summary>
        /// MTADD13.
        /// </summary>
        public const string MTADD13 = "MTADD13";

        /// <summary>
        /// MTADD14.
        /// </summary>
        public const string MTADD14 = "MTADD14";

        /// <summary>
        /// MTCTYNH3.
        /// </summary>
        public const string MTCTYNH3 = "MTCTYNH3";

        /// <summary>
        /// MTADDSNH3.
        /// </summary>
        public const string MTADDSNH3 = "MTADDSNH3";

        /// <summary>
        /// MTADDZNH3.
        /// </summary>
        public const string MTADDZNH3 = "MTADDZNH3";

        /// <summary>
        /// MTCRTENH3.
        /// </summary>
        public const string MTCRTENH3 = "MTCRTENH3";

        /// <summary>
        /// MTDL05.
        /// </summary>
        public const string MTDL05 = "MTDL05";

        /// <summary>
        /// MTFPC5.
        /// </summary>
        public const string MTFPC5 = "MTFPC5";

        /// <summary>
        /// MTPH3.
        /// </summary>
        public const string MTPH3 = "MTPH3";

        /// <summary>
        /// MTPH4.
        /// </summary>
        public const string MTPH4 = "MTPH4";

        /// <summary>
        /// MTPHO1.
        /// </summary>
        public const string MTPHO1 = "MTPHO1";

        /// <summary>
        /// MTDTI3.
        /// </summary>
        public const string MTDTI3 = "MTDTI3";

        /// <summary>
        /// MTSCOD.
        /// </summary>
        public const string MTSCOD = "MTSCOD";

        /// <summary>
        /// MTEV03.
        /// </summary>
        public const string MTEV03 = "MTEV03";

        /// <summary>
        /// MTDTI4.
        /// </summary>
        public const string MTDTI4 = "MTDTI4";
    }

    /// <inheritdoc />
    public override string TableName => "F8907427";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("MTMATH01", "MTMATH01", JdeDataType.Numeric, null, true, true),
        new JdeField("MTEV01", "MTEV01", JdeDataType.String, 2),
        new JdeField("MTDTI1", "MTDTI1", JdeDataType.String, 20),
        new JdeField("MTMATH02", "MTMATH02", JdeDataType.Numeric),
        new JdeField("MTALPH1", "MTALPH1", JdeDataType.String, 80),
        new JdeField("MTTAXX", "MTTAXX", JdeDataType.String, 40),
        new JdeField("MTETAX", "MTETAX", JdeDataType.String, 40),
        new JdeField("MTADD4", "MTADD4", JdeDataType.String, 80),
        new JdeField("MTADD5", "MTADD5", JdeDataType.String, 80),
        new JdeField("MTMSCY", "MTMSCY", JdeDataType.String, 50),
        new JdeField("MTSTCD", "MTSTCD", JdeDataType.String, 6),
        new JdeField("MTADDO", "MTADDO", JdeDataType.String, 24),
        new JdeField("MTCRRT", "MTCRRT", JdeDataType.String, 8),
        new JdeField("MTDL02", "MTDL02", JdeDataType.String, 60),
        new JdeField("MTFPC2", "MTFPC2", JdeDataType.String, 30),
        new JdeField("MTALPH3", "MTALPH3", JdeDataType.String, 80),
        new JdeField("MTPH1", "MTPH1", JdeDataType.String, 40),
        new JdeField("MTPXT1", "MTPXT1", JdeDataType.String, 10),
        new JdeField("MTPH2", "MTPH2", JdeDataType.String, 40),
        new JdeField("MTEV02", "MTEV02", JdeDataType.String, 2),
        new JdeField("MTADD10", "MTADD10", JdeDataType.String, 80),
        new JdeField("MTADD11", "MTADD11", JdeDataType.String, 80),
        new JdeField("MTCTYNH2", "MTCTYNH2", JdeDataType.String, 50),
        new JdeField("MTADDSNH2", "MTADDSNH2", JdeDataType.String, 6),
        new JdeField("MTADDZNH2", "MTADDZNH2", JdeDataType.String, 24),
        new JdeField("MTCRTENH2", "MTCRTENH2", JdeDataType.String, 8),
        new JdeField("MTDL03", "MTDL03", JdeDataType.String, 60),
        new JdeField("MTFPC4", "MTFPC4", JdeDataType.String, 30),
        new JdeField("MTDTI2", "MTDTI2", JdeDataType.String, 20),
        new JdeField("MTSSN", "MTSSN", JdeDataType.String, 40),
        new JdeField("MTSRNM", "MTSRNM", JdeDataType.String, 50),
        new JdeField("MTGNNM", "MTGNNM", JdeDataType.String, 50),
        new JdeField("MTMDNM", "MTMDNM", JdeDataType.String, 50),
        new JdeField("MTADD1", "MTADD1", JdeDataType.String, 80),
        new JdeField("MTADD2", "MTADD2", JdeDataType.String, 80),
        new JdeField("MTCTY1", "MTCTY1", JdeDataType.String, 50),
        new JdeField("MTADDS", "MTADDS", JdeDataType.String, 6),
        new JdeField("MTADDZ", "MTADDZ", JdeDataType.String, 24),
        new JdeField("MTCRTE", "MTCRTE", JdeDataType.String, 8),
        new JdeField("MTDL04", "MTDL04", JdeDataType.String, 60),
        new JdeField("MTFPC1", "MTFPC1", JdeDataType.String, 30),
        new JdeField("MTADD13", "MTADD13", JdeDataType.String, 80),
        new JdeField("MTADD14", "MTADD14", JdeDataType.String, 80),
        new JdeField("MTCTYNH3", "MTCTYNH3", JdeDataType.String, 50),
        new JdeField("MTADDSNH3", "MTADDSNH3", JdeDataType.String, 6),
        new JdeField("MTADDZNH3", "MTADDZNH3", JdeDataType.String, 24),
        new JdeField("MTCRTENH3", "MTCRTENH3", JdeDataType.String, 8),
        new JdeField("MTDL05", "MTDL05", JdeDataType.String, 60),
        new JdeField("MTFPC5", "MTFPC5", JdeDataType.String, 30),
        new JdeField("MTPH3", "MTPH3", JdeDataType.String, 40),
        new JdeField("MTPH4", "MTPH4", JdeDataType.String, 40),
        new JdeField("MTPHO1", "MTPHO1", JdeDataType.Numeric),
        new JdeField("MTDTI3", "MTDTI3", JdeDataType.String, 20),
        new JdeField("MTSCOD", "MTSCOD", JdeDataType.String, 6),
        new JdeField("MTEV03", "MTEV03", JdeDataType.String, 2),
        new JdeField("MTDTI4", "MTDTI4", JdeDataType.String, 20)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F8907427_0", "Primary Key on MTMATH01", new[] { "MTMATH01" }, isUnique: true, isPrimaryKey: true)
    };
}
